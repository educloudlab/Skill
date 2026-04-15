using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AisectOnline.Common.Users
{
    public interface IUserContextService
    {
        //string? GetCurrentUserId();
        string GetUserId();
        string GetUserEmail();
        IEnumerable<string> GetUserRoles();
    }
}

