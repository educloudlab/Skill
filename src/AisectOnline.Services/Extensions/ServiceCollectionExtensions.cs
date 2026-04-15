using AisectOnline.Common.Users;
using AisectOnline.Data.Db;
using AisectOnline.Services.Modules.Accounts;
using AisectOnline.Services.Modules.Common;
using AisectOnline.Services.Modules.MasterData;
using AisectOnline.Services.Modules.Roles;
using AisectOnline.Services.Modules.Skill;
using AisectOnline.Services.Modules.StudentAssignment;
using AisectOnline.Services.Modules.Students;
using AisectOnline.Services.Modules.Users;
using Microsoft.AspNetCore.Http;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace AisectOnline.Services.Extensions
{
    public static partial class ServiceCollectionExtensions
    {
        public static IServiceCollection AddAisectOnlineServices(this IServiceCollection services, IConfiguration config)
        {
            // DbContext
            services.AddDbContext<AisectOnlineDbContext>(options =>
                options.UseSqlServer(config.GetConnectionString("DefaultConnection")));

            // Domain/Business Services
            services.AddScoped<IAccountService, AccountRepository>();
            services.AddScoped<IStudentContextService, StudentContextService>();
            services.AddScoped<IMasterDataService, MasterDataService>();
            services.AddScoped<IStudentService, StudentRepository>();
            services.AddScoped<IUserContextService, UserContextService>();
            services.AddScoped<ICommonService, CommonService>();
            services.AddScoped<IRoleSeeder, RoleSeeder>();

            // Session/context
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
            services.AddScoped<ISessionInitializer, SessionInitializer>();
            services.AddScoped<IAssignmentServices, AssignmentServices>();
            services.AddScoped<AssignmentServices>();

            services.AddScoped<ExcelUpload>();

            return services;
        }
    }
}
