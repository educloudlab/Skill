
using System.Collections.Generic;
using System.Threading.Tasks;

namespace AisectOnline.Services.Base;

public interface IBaseService<T> where T : class
{
    Task<List<T>> GetAllAsync();
    Task<T?> GetByIdAsync(int id);
    Task<T> CreateAsync(T dto);
    Task<T> UpdateAsync(int id, T TDto);
    Task<bool> DeleteAsync(int id);

}
