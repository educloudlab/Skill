
// AisectOnline.Common/Extensions/ServiceCollectionExtensions.cs
namespace AisectOnline.Common.Session;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Net.Http.Headers;
using AisectOnline.Common.Clients;
using Microsoft.IdentityModel.Tokens;
using System.Text;
using Microsoft.AspNetCore.Http;
using AisectOnline.Common.Users;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using AisectOnline.Common.Session;
//using AisectOnline.Services.Modules.Users;
//using AisectOnline.Common.Services;

public static partial class ServiceCollectionExtensions
{
    public static IServiceCollection AddCommonHttpClients(this IServiceCollection services, IConfiguration config)
    {
        services.AddHttpClient<IApiClient, ApiClient>(c =>
        {
            c.Timeout = TimeSpan.FromSeconds(30);
            c.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            var baseUrl = config["ExternalApi:BaseUrl"];
            if (!string.IsNullOrEmpty(baseUrl)) c.BaseAddress = new Uri(baseUrl);
        });
        return services;
    }

    public static IServiceCollection AddJwtAuthentication(this IServiceCollection services, IConfiguration config)
    {
        var jwt = config.GetSection("JwtSettings");
        var key = Encoding.UTF8.GetBytes(jwt["Key"]!);
        services.AddAuthentication(options => {
            options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
            options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
        })
        .AddJwtBearer(opts => {
            opts.TokenValidationParameters = new TokenValidationParameters
            {
                ValidateIssuer = true,
                ValidateAudience = true,
                ValidateLifetime = true,
                ValidateIssuerSigningKey = true,
                ValidIssuer = jwt["Issuer"],
                ValidAudience = jwt["Audience"],
                IssuerSigningKey = new SymmetricSecurityKey(key)
            };
        });
        return services;
    }

    public static IServiceCollection AddSessionServices(this IServiceCollection services)
    {
        services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
        //services.AddScoped<IUserContextService, UserContextService>();
        services.AddScoped<ISessionInitializer, SessionInitializer>();
        return services;
    }
}

