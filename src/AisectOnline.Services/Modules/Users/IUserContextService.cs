using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Services.Modules.Users
{
    public interface IUserContextService
    {
        //string? GetCurrentUserId();
        UserContextModel? GetUserContext();
        //string GetUserId();
        //string GetUserEmail();
        //IEnumerable<string> GetUserRoles();
    }
}

