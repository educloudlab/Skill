using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AisectOnline.Services.Modules.Common.CommonDTO;

namespace AisectOnline.Services.Modules.Common
{
    public interface ICommonService
    {
        Task<List<RoleMenu>> GetMenusAsync(string controllerName, int UserID);
        Task<string> SavePhotoAsync(string uploadFolder, IFormFile photo, string requestNo);

    }
}
