using AisectOnline.Data.Db;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Data;

//using System.Data;
//using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static AisectOnline.Services.Modules.Common.CommonDTO;

namespace AisectOnline.Services.Modules.Common
{
    public class CommonService : ICommonService
    {
        private readonly IConfiguration _config;
        private readonly AisectOnlineDbContext _db;
        public CommonService(IConfiguration config, AisectOnlineDbContext db)
        {
            _config = config;
            _db = db;

        }
        public async Task<List<RoleMenu>> GetMenusAsync(string controllerName, int userId)
        {
            try
            {
                var parameters = new[]
            {
        new SqlParameter("@ControllerName", controllerName),
        new SqlParameter("@UserId", userId)
    };

                return await _db.Database
                    .SqlQuery<RoleMenu>($"EXEC sp_GetMenu @ControllerName={controllerName}, @UserId={userId}")
                    .ToListAsync();
            }
            catch(Exception ex)
            {
                throw ex;
            }
        }
        //save Image or Photo
        public async Task<string> SavePhotoAsync(string uploadFolder, IFormFile photo, string Name)
        {
            if (photo == null || photo.Length == 0)
            {
                return null;
            }

            var uploadsFolder = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot", uploadFolder);

            if (!Directory.Exists(uploadsFolder))
            {
                Directory.CreateDirectory(uploadsFolder);
            }
           if (uploadFolder=="ServiceLogo")
            {
                var existingFiles = Directory.GetFiles(uploadsFolder, Name + ".*");
                foreach (var existingFile in existingFiles)
                {
                    System.IO.File.Delete(existingFile);//remove Existing file for service logo
                }
            }


            var uniqueFileName = Name + Path.GetExtension(photo.FileName);
            var filePath = Path.Combine(uploadsFolder, uniqueFileName);
           
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await photo.CopyToAsync(stream);
            }

            return $"/{uploadFolder}/{uniqueFileName}";
        }

    }
}
