using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Http;
using System.Security.Cryptography;

namespace AisectOnline.Common.Helpers
{
    /// <summary>
    /// SecurityHelper provides methods to sign-in and sign-out users using Cookie Authentication in ASP.NET Core.
    /// </summary>
    public class SecurityHelper
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="httpContextAccessor"></param>
        public SecurityHelper(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        /// <summary>
        /// Signs in the user with specified claims and roles
        /// </summary>
        /// <param name="loginId">Login ID of the user</param>
        /// <param name="roles">List of roles for the user</param>
        /// <param name="rememberMe">Whether to persist cookie</param>
        /// <param name="timeOutMinutes">Cookie expiration in minutes</param>
        public async Task SignInAsync(string loginId, IEnumerable<string> roles, bool rememberMe, double timeOutMinutes)
        {
            var claims = new List<Claim>
            {
                new Claim(ClaimTypes.NameIdentifier, loginId),
                new Claim(ClaimTypes.Name, loginId)
            };
            foreach (var role in roles)
            {
                claims.Add(new Claim(ClaimTypes.Role, role));
            }

            var claimsIdentity = new ClaimsIdentity(claims, CookieAuthenticationDefaults.AuthenticationScheme);
            var authProperties = new AuthenticationProperties
            {
                IsPersistent = rememberMe,
                ExpiresUtc = DateTime.UtcNow.AddMinutes(timeOutMinutes),
                AllowRefresh = true,
                IssuedUtc = DateTime.UtcNow
            };

            await _httpContextAccessor.HttpContext.SignInAsync(
                CookieAuthenticationDefaults.AuthenticationScheme,
                new ClaimsPrincipal(claimsIdentity),
                authProperties);
        }

        /// <summary>
        /// Signs out the current user
        /// </summary>
        public async Task SignOutAsync()
        {
            await _httpContextAccessor.HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        }

        /// <summary>
        /// Static helper for one-off sign-in
        /// </summary>
        public static async Task SignInAsync(HttpContext httpContext, string loginId, IEnumerable<string> roles, bool rememberMe, double timeOutMinutes)
        {
            var helper = new SecurityHelper(new HttpContextAccessor { HttpContext = httpContext });
            await helper.SignInAsync(loginId, roles, rememberMe, timeOutMinutes);
        }

        /// <summary>
        /// Static helper for one-off sign-out
        /// </summary>
        public static async Task SignOutAsync(HttpContext httpContext)
        {
            var helper = new SecurityHelper(new HttpContextAccessor { HttpContext = httpContext });
            await helper.SignOutAsync();
        }

        public static string HashPassword(string password)
        {
            using var sha = SHA256.Create();
            var bytes = Encoding.UTF8.GetBytes(password);
            var hash = sha.ComputeHash(bytes);
            return Convert.ToBase64String(hash);
        }

        public static bool VerifyPassword(string hash, string password)
        {
            var hashedInput = HashPassword(password);
            return hash == hashedInput;
        }
    }
}
