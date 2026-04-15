
namespace AisectOnline.Services.Base;

using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AisectOnline.Data.Db;

/// <summary>
/// Abstract base class implementing generic CRUD operations via EF Core.
/// </summary>
public abstract class BaseService<TEntity, TDto> : IBaseService<TDto>
    where TEntity : class, new()
    where TDto : class, new()
{
    protected readonly AisectOnlineDbContext _db;
    protected readonly ILogger _logger;

    /// <summary>
    /// Exposes the configured connection string from DbContext.
    /// </summary>
    protected string ConnectionString => _db.Database.GetDbConnection().ConnectionString;

    protected BaseService(AisectOnlineDbContext db, ILogger logger)
    {
        _db = db;
        _logger = logger;
    }

    public async Task<List<TDto>> GetAllAsync()
    {
        var entities = await _db.Set<TEntity>().ToListAsync();
        return entities.Select(ToDto).ToList();
    }

    public async Task<TDto?> GetByIdAsync(int id)
    {
        var entity = await _db.Set<TEntity>().FindAsync(id);
        return entity == null ? null : ToDto(entity);
    }

    public async Task<TDto> CreateAsync(TDto dto)
    {
        var entity = ToEntity(dto);
        _db.Set<TEntity>().Add(entity);
        await _db.SaveChangesAsync();
        return ToDto(entity);
    }

    public async Task<TDto> UpdateAsync(int id, TDto dto)
    {
        var entity = await _db.Set<TEntity>().FindAsync(id) ?? throw new KeyNotFoundException($"{typeof(TEntity).Name}({id}) not found");
        UpdateEntity(entity, dto);
        await _db.SaveChangesAsync();
        return ToDto(entity);
    }

    public async Task<bool> DeleteAsync(int id)
    {
        var entity = await _db.Set<TEntity>().FindAsync(id);
        if (entity == null) return false;
        _db.Set<TEntity>().Remove(entity);
        await _db.SaveChangesAsync();
        return true;
    }

    protected abstract TDto ToDto(TEntity entity);
    protected abstract TEntity ToEntity(TDto dto);
    protected abstract void UpdateEntity(TEntity entity, TDto dto);
}

