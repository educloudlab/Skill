using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using System.Security.Claims;

namespace AisectOnline.Services.Modules.Users
{
    public class UserContextService : IUserContextService
    {
        private readonly IHttpContextAccessor _httpContextAccessor;

        public UserContextService(IHttpContextAccessor httpContextAccessor)
        {
            _httpContextAccessor = httpContextAccessor;
        }

        public UserContextModel? GetUserContext()
        {
            var httpContext = _httpContextAccessor.HttpContext;

            if (httpContext == null)
                return null;

            var user = httpContext.User;

            if (user == null || !user.Identity?.IsAuthenticated == true)
                return null;

            return new UserContextModel
            {
                UserId = user.FindFirst("UserId")?.Value,
                UserName = user.Identity?.Name,
                Role = user.FindFirst("Role")?.Value,
                Email = user.FindFirst("Email")?.Value
            };
        }


    }

}

