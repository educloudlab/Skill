
using AisectOnline.Common.Middleware;
using AisectOnline.Common.Models;
using AisectOnline.Common.Session;
using AisectOnline.Data.Db;
using AisectOnline.Services.Extensions;
using AisectOnline.Services.Modules.Roles;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Identity;
using Serilog;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;

// Logging
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(config)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();
builder.Host.UseSerilog();

// Register all domain/business/data/common services
builder.Services.AddAisectOnlineServices(config);

// Register common HTTP clients
builder.Services.AddCommonHttpClients(config);

// Framework and pipeline services
builder.Services.AddRazorPages();
builder.Services.AddMemoryCache();
builder.Services.AddControllersWithViews();
//builder.Services.AddControllersWithViews(options =>
//{
//    options.Filters.Add(new Microsoft.AspNetCore.Mvc.Authorization.AuthorizeFilter());
//});
builder.Services.AddRazorPages(options =>
{
    options.Conventions.AuthorizeFolder("/");
    options.Conventions.AllowAnonymousToPage("/Account/LogOn");
});


builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks().AddDbContextCheck<AisectOnline.Data.Db.AisectOnlineDbContext>();
builder.Services.AddCors(o => o.AddPolicy("Default", p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
builder.Services.AddControllers()
    .AddJsonOptions(opts => {
        opts.JsonSerializerOptions.PropertyNamingPolicy = null; // Keeps PascalCase
    });


// Data Protection
var dpKeysPath = config["DataProtectionKeys:Path"];
if (string.IsNullOrEmpty(dpKeysPath) || !Path.IsPathRooted(dpKeysPath) || !Directory.Exists(Path.GetPathRoot(dpKeysPath)))
{
    dpKeysPath = Path.Combine(builder.Environment.ContentRootPath, "DataProtectionKeys");
}
Directory.CreateDirectory(dpKeysPath);
builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(dpKeysPath))
    .SetApplicationName("AisectOnlineERP");

// Authentication & Identity
builder.Services.AddAuthentication("MyCookieAuth")
    .AddCookie("MyCookieAuth", options =>
    {
        options.LoginPath = "/Account/LogOn";
        options.LogoutPath = "/Account/LogOff";
    });

builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
    .AddEntityFrameworkStores<AisectOnlineDbContext>()
    .AddDefaultTokenProviders();

// Session
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

var app = builder.Build();

// Seed Roles
using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<IRoleSeeder>();
    await seeder.SeedAsync();
}

// Pipeline
app.UseSerilogRequestLogging();
app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseCors("Default");

app.UseAuthentication();
app.UseAuthorization();

app.MapControllerRoute("default", "{controller=Account}/{action=LogOn}/{id?}");

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapHealthChecks("/health");
//app.MapControllerRoute("default", "{controller=Account}/{action=LogOn}/{id?}");
app.Run();



/*using AisectOnline.Common.Middleware;
using AisectOnline.Common.Session;
using AisectOnline.Common.Users;
using AisectOnline.Services.Extensions;
using AisectOnline.Services.Modules.Accounts;
using AisectOnline.Services.Modules.Roles;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.IdentityModel.Tokens;
using Serilog;
using System.Text;
using AisectOnline.Services.Modules.Users;
using AisectOnline.Data.Db;
using Microsoft.AspNetCore.Identity;
using AisectOnline.Common.Models;
using AisectOnline.Services.Modules.Students;
using AisectOnline.Services.Modules.MasterData;

var builder = WebApplication.CreateBuilder(args);
var config = builder.Configuration;



// -- Logging
Log.Logger = new LoggerConfiguration()
    .ReadFrom.Configuration(config)
    .Enrich.FromLogContext()
    .WriteTo.Console()
    .CreateLogger();
builder.Host.UseSerilog();

// -- EF Core & Domain Services
builder.Services.AddAisectOnlineServices(config);

// -- Data Protection (shared keys)
builder.Services.AddDataProtection()
    .PersistKeysToFileSystem(new DirectoryInfo(config["DataProtectionKeys:Path"]))
    .SetApplicationName("AisectOnlineERP");
builder.Services.AddAuthentication("MyCookieAuth")
    .AddCookie("MyCookieAuth", options =>
    {
        options.LoginPath = "/Account/LogOn";
        options.LogoutPath = "/Account/LogOff";
        // You can set other options as needed
    });

/*
// -- Identity & JWT (cookie-based)  
/*builder.Services.AddAuthentication(options =>
{
    options.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
    options.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
})
.AddJwtBearer(opts =>
{
    opts.Events = new JwtBearerEvents
    {
        OnMessageReceived = ctx =>
        {
            ctx.Token = ctx.Request.Cookies["AisectERP.Auth"];
            return Task.CompletedTask;
        }
    };
    var jwt = config.GetSection("JwtSettings");
    var key = Encoding.UTF8.GetBytes(jwt["Key"]!);
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
*/
// -- User Context & Session
//builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
//builder.Services.AddScoped<IUserContextService, UserContextService>();
//builder.Services.AddScoped<ISessionInitializer, SessionInitializer>();

// -- Session & Cache (Redis)
//builder.Services.AddStackExchangeRedisCache(options =>
//{
//    options.Configuration = config.GetConnectionString("Redis");
//    options.InstanceName = "AisectOnline:";
//});
/*builder.Services.AddRazorPages();
builder.Services.AddSession(options =>
{
    options.IdleTimeout = TimeSpan.FromMinutes(30);
    options.Cookie.HttpOnly = true;
    options.Cookie.IsEssential = true;
});

// -- External HTTP Clients
builder.Services.AddCommonHttpClients(config);
//builder.Services.AddScoped<IAccountService, AccountRepository>();
//builder.Services.AddScoped<IStudentContextService, StudentContextService>();
//builder.Services.AddScoped<IMasterDataService, MasterDataService>();
//builder.Services.AddScoped<IStudentService, StudentRepository>();

// -- Middleware, Swagger, Health, CORS
builder.Services.AddControllersWithViews();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddHealthChecks().AddDbContextCheck<AisectOnline.Data.Db.AisectOnlineDbContext>();
builder.Services.AddCors(o => o.AddPolicy("Default", p => p.AllowAnyOrigin().AllowAnyHeader().AllowAnyMethod()));
//using Microsoft.AspNetCore.Identity;/
//using AisectOnline.Data.Db; // Use your actual DbContext namespace

// Add Identity services
//builder.Services.AddIdentity<IdentityUser, IdentityRole>()
//    .AddEntityFrameworkStores<AisectOnlineDbContext>()
//    .AddDefaultTokenProviders();
/*builder.Services.AddIdentity<ApplicationUser, ApplicationRole>()
    .AddEntityFrameworkStores<AisectOnlineDbContext>()
    .AddDefaultTokenProviders();

var app = builder.Build();

// -- Seed Roles
using (var scope = app.Services.CreateScope())
{
    var seeder = scope.ServiceProvider.GetRequiredService<IRoleSeeder>();
    await seeder.SeedAsync();
}

// -- Pipeline
app.UseSerilogRequestLogging();
app.UseMiddleware<ExceptionMiddleware>();
app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseSession();
app.UseRouting();
app.UseCors("Default");
app.UseAuthentication();
app.UseAuthorization();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.MapHealthChecks("/health");
app.MapControllerRoute("default", "{controller=Account}/{action=LogOn}/{id?}");
app.Run();

*/