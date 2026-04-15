//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using Microsoft.AspNetCore.Http;
//using System.Security.Claims;
//using AisectOnline.Common.Users;

//namespace AisectOnline.Common.Services
//{
//    public class UserContextService : IUserContextService
//    {
//        private readonly IHttpContextAccessor _httpContextAccessor;

//        public UserContextService(IHttpContextAccessor httpContextAccessor)
//        {
//            _httpContextAccessor = httpContextAccessor;
//        }

//        public string GetUserId()
//        {
//            var userId = _httpContextAccessor.HttpContext?.User?
//    .Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier)?.Value;
//            return userId ?? string.Empty;
//            //return _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes);
//        }

//        public string GetUserEmail()
//        {

//            var email = _httpContextAccessor.HttpContext?.User?
//    .Claims.FirstOrDefault(c => c.Type == ClaimTypes.Email)?.Value;
//            return email ?? string.Empty;
//            //return _httpContextAccessor.HttpContext?.User?.FindFirstValue(ClaimTypes.Email);
//        }

//        public IEnumerable<string> GetUserRoles()
//        {
//            return _httpContextAccessor.HttpContext?.User?.Claims
//                .Where(c => c.Type == ClaimTypes.Role)
//                .Select(c => c.Value) ?? Enumerable.Empty<string>();
//        }
//    }
//}
using System.Security.Claims;
using Microsoft.AspNetCore.Http;
using AisectOnline.Common.Users;

namespace AisectOnline.Services.Modules.Users
{
    public class UserContextService : IUserContextService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserContextService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public string GetUserId()
        {
            return _httpContextAccessor.HttpContext?.User?
                .FindFirstValue(ClaimTypes.NameIdentifier) ?? string.Empty;
        }

        public string GetUserEmail()
        {
            return _httpContextAccessor.HttpContext?.User?
                .FindFirstValue(ClaimTypes.Email) ?? string.Empty;
        }

        public IEnumerable<string> GetUserRoles()
        {
            return _httpContextAccessor.HttpContext?.User?
                .Claims
                .Where(c => c.Type == ClaimTypes.Role)
                .Select(c => c.Value)
                ?? Enumerable.Empty<string>();
        }

        public UserContextModel? GetUserContext()
        {
            var user = _httpContextAccessor.HttpContext?.User;
            if (user == null || !user.Identity?.IsAuthenticated == true)
                return null;

            return new UserContextModel
            {
                UserId = user.FindFirstValue(ClaimTypes.NameIdentifier),
                UserName = user.Identity.Name ?? user.FindFirstValue(ClaimTypes.Name) ?? string.Empty,
                Email = user.FindFirstValue(ClaimTypes.Email),
                Role = user.FindFirstValue(ClaimTypes.Role) // Returns the first role, or you can join all roles if needed
            };
        }
    }
}
