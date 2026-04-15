namespace AisectOnline.Data.Extensions;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
//using AisectOnline.Data.Modules.Student;
using AisectOnline.Data.Seeders;
using Microsoft.EntityFrameworkCore;
using global::AisectOnline.Data.Db;
using global::AisectOnline.Data.Modules.Roles;
using global::AisectOnline.Data.Modules.Students;
using IRoleSeeder = Modules.Roles.IRoleSeeder;
using RoleSeeder = Modules.Roles.RoleSeeder;

public static class ServiceCollectionExtensions
{
    public static IServiceCollection AddAisectOnlineData(this IServiceCollection Data, IConfiguration config)
    {
        Data.AddDbContext<AisectOnlineDbContext>(o => o.UseSqlServer(config.GetConnectionString("DefaultConnection")));
        Data.AddScoped<IStudentContextService, StudentContextService>();
        Data.AddScoped<IRoleSeeder, RoleSeeder>();
        return Data;
    }
}
