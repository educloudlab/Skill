using AisectOnline.Common.Users;
using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.Admin;
using AisectOnline.Services.Modules.Common;
using AisectOnline.Services.Modules.MasterData;
using AisectOnline.Services.Modules.Students;
using AisectOnline.Services.Modules.Users;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Caching.Memory;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Text.Json;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AisectOnline.Web.Controllers
{
    public class AdminController : BaseController
    {
        private readonly IMasterDataService _masterDataService;
        private readonly ICommonService _commonService;
        private readonly ISessionInitializer _sessionInit;
        private readonly IMemoryCache _cache;
        private readonly ILogger<AdminController> _logger;
        public AdminController(IMasterDataService masterDataService, ILogger<StudentController> logger,
             ISessionInitializer sessionInit,
        IUserContextService userContext, ICommonService commonService, ILogger<AdminController> loggerr, IMemoryCache cache) : base(logger, userContext, sessionInit)
        {
            _masterDataService = masterDataService;
            _commonService = commonService;
            _logger = loggerr;
            _cache = cache;

        }
        //views------------Master Data
        public async Task<IActionResult> MasterDataList()
        {
            MasterDataListDto MDTL = new MasterDataListDto();
            MDTL.MasterDataTypeList = (await _masterDataService.GetMasterList()).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
            return View(MDTL);
        }
        //views------------Program design
        public async Task<IActionResult> FeeTypeList()
        {
            return View();
        }
        public async Task<IActionResult> AcademicSession()
        {
            return View();
        }
        public async Task<IActionResult> CourseSchemeMaster()
        {
            return View();
        }
        public async Task<IActionResult> CourseCategory()
        {
            return View();
        }
        public async Task<IActionResult> CourseFeeMode()
        {
            return View();
        }
        public async Task<IActionResult> CourseOptionalSubjects()
        {

            return View();
        }
        public async Task<IActionResult> AcademyAllotment()
        {
            AcademyAllotmentDto dto = new AcademyAllotmentDto();
            dto.Academy = (await _masterDataService.GetAccademyList()).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
            return View(dto);
        }
        public async Task<IActionResult> ProgramAllotment()

        {


            return View();
        }
        [HttpGet]
        public async Task<IActionResult> GetKioskList(DataSourceLoadOptions loadOptions)
        {
            string cacheKey = "Kiosk_All"; // cache full list once
            if (!_cache.TryGetValue(cacheKey, out List<ProgrammeListItems> kiosksQuery))
            {
                // Get only IQueryable, not ToList() → allows EF to page
                kiosksQuery = await _masterDataService.GetAllKiosk();

                // keep as queryable in memory cache (if DB hit is expensive)
                _cache.Set(cacheKey, kiosksQuery, new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromMinutes(10),
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1),
                    Priority = CacheItemPriority.High
                });
            }

            // DevExtreme applies skip/take/filter/search automatically
            var result = DataSourceLoader.Load(kiosksQuery, loadOptions);
            return Json(result);
        }
        [HttpGet]
        public IActionResult _MasterDataGrid(int typeId)
        {
            return PartialView("_MasterDataGrid", typeId);
        }

        [HttpGet]
        public async Task<IActionResult> GetMasterDataList(int typeId)
        {
            var data = await _masterDataService.GetMasterData(typeId);
            return Json(data);
        }

        // Create Master Data (Insert)
        [HttpPost]
        public async Task<IActionResult> CreateMasterData(string values, int typeId)
        {
            try
            {
                var model = new ListItems();
                JsonConvert.PopulateObject(values, model);
                var result = await _masterDataService.UpdateAndCreateMasterData(typeId, model, 5609, "Admin");
                if (result == -1)
                    return BadRequest("Duplicate entry");
                if (result == 0)
                    return BadRequest("Error occurs while processing your request.");

                return Ok(model);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        // Update Master Data
        [HttpPut]
        public async Task<IActionResult> UpdateMasterData(int key, string values, int typeId)
        {
            try
            {
                // Deserialize JSON string into ListItems
                var model = JsonConvert.DeserializeObject<ListItems>(values);
                if (model == null)
                    return BadRequest("Invalid data format.");

                // Ensure key is applied (in case it's missing in JSON)
                model.ValueField = key;

                var result = await _masterDataService.UpdateAndCreateMasterData(typeId, model, 5609, "Admin");

                if (result == -1)
                    return BadRequest("Duplicate entry");
                if (result == 0)
                    return BadRequest("Error occurs while processing your request.");

                return Ok(model);

            }
            catch (Exception ex)
            {
                throw ex;
            }

        }

        // Delete Master Data
        [HttpDelete]
        public async Task<IActionResult> DeleteMasterData(int key, int typeId)
        {
            try
            {

                var result = await _masterDataService.DaleteMasterData(typeId, key);
                return Ok(new { success = result > 0 });
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        //load data
        public async Task<IActionResult> GetCourseOptionalSub(DataSourceLoadOptions loadOptions)
        {
            var data = await _masterDataService.CourseSubjectsOpt();
            return Json(DataSourceLoader.Load(data, loadOptions));
        }
        ///UPDATE
        [HttpPut]
        public async Task<IActionResult> UpdateCourseOptionalSub(int key, string values)
        {
            try
            {
                var data = JsonConvert.DeserializeObject<CourseSubjectsOpt>(values);
                var d1 = data;
                var result = await _masterDataService.UpdateCourseOptionalSub(key, data.NoOfOptionalsub);

                if (result <= 0)
                    return BadRequest("Update failed.");

                return Ok(new { CPMMappingID = key, data.NoOfOptionalsub });
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }
        //get Program List by AcademyID 
        [HttpGet]
        public async Task<IActionResult> GetCheckBoxList(int AcademyId)
        {
            try
            {
                var data = await _masterDataService.GetProgrammeListByCCID(AcademyId);
                return Json(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        [HttpPost]
        public async Task<IActionResult> AllotSelectedPrograms([FromBody] JsonElement data)
        {
            var idsList = data.GetProperty("Ids").EnumerateArray().Select(x => x.GetInt32()).ToList();
            string idsString = string.Join(",", idsList);

            int academyId2 = data.GetProperty("AcademyId2").GetInt32();
            var result = await _masterDataService.AcademyAllotment(academyId2, idsString, 5609);

            if (result > 0)
            {
                var redirectUrl = Url.Action("AcademyAllotment", "Admin");
                return Ok(new
                {
                    message = "Allotment updated successfully",
                    idsString,
                    redirectUrl
                });
            }
            else
            {
                return BadRequest("Allotment update failed.");
            }

        }
        [HttpGet]
        public async Task<List<ListItems>> Getservices(int Kioskid)
        {
            try
            {
                var services = await _masterDataService.GetServiceByKiosk(Kioskid);

                if (services != null && services.Any())
                {
                    return services;
                }
                else
                {
                    return new List<ListItems>();
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpGet]
        public async Task<List<ListItems>> GetCourseCtgByServiceId(int KioskId, int serviceId)
        {
            try
            {
                var services = await _masterDataService.GetCourseCtgByserviceID(serviceId, KioskId);

                if (services != null && services.Any())
                {
                    return services;
                }
                else
                {
                    return new List<ListItems>();
                }

            }
            catch (Exception)
            {
                throw;
            }

        }
        [HttpGet]
        public async Task<IActionResult> GetCheckBoxForProgramAllotment(int? KioskId, int? serviceId, int IsAlloted, int? CourseCategoryId, int? programId)
        {
            try
            {
                var data = await _masterDataService.GetCheckBoxForProgramAllotment(KioskId, serviceId, IsAlloted, CourseCategoryId, programId);
                return Json(data);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        List<int> ParseIntList(JsonElement element)
        {
            var list = new List<int>();
            if (element.ValueKind == JsonValueKind.Array)
            {
                list = element.EnumerateArray().Select(x => x.GetInt32()).ToList();
            }
            else if (element.ValueKind == JsonValueKind.Number)
            {
                list.Add(element.GetInt32());
            }
            return list;
        }
        [HttpPost]
        public async Task<IActionResult> ProgramAllotmentPost([FromBody] JsonElement data)
        {
            try
            {
                // Assuming 'data' is a JsonElement representing your JSON object
                var idsList = ParseIntList(data.GetProperty("Ids"));
                string idsString = string.Join(",", idsList);

                var kioskIdsList = ParseIntList(data.GetProperty("KioskID"));
                string kioskIdsString = string.Join(",", kioskIdsList);
                int ServiceId = data.GetProperty("ServiceId").GetInt32();
                int CoursecategoryID = data.GetProperty("CourseCategeryId").GetInt32();
                int UserID = 5609;
                var result = await _masterDataService.ProgramAllotmentPost(kioskIdsString, idsString, ServiceId, UserID, CoursecategoryID);
                if (result > 0)
                {
                    var redirectUrl = Url.Action("ProgramAllotment", "Admin");
                    return Ok(new
                    {
                        message = "Allotment updated successfully",
                        idsString,
                        redirectUrl
                    });
                }
                else
                {
                    return BadRequest("Allotment update failed.");
                }
            }
            catch(Exception ex) {
                throw;
            }

        }
        [HttpGet]
        public async Task<IActionResult> GetAllPrograms1(DataSourceLoadOptions loadOptions)
        {
            string cacheKey = "Program_All";

            if (!_cache.TryGetValue(cacheKey, out List<ListItems> programQuery))
            {
                // Await because service returns Task<List<ListItems>>
                programQuery = await _masterDataService.GetAllPrograms();

                // Cache the list
                _cache.Set(cacheKey, programQuery, new MemoryCacheEntryOptions
                {
                    SlidingExpiration = TimeSpan.FromMinutes(10),
                    AbsoluteExpirationRelativeToNow = TimeSpan.FromHours(1),
                    Priority = CacheItemPriority.High
                });
            }

            // DevExtreme requires IQueryable or IEnumerable
            var result = DataSourceLoader.Load(programQuery.AsQueryable(), loadOptions);

            return Json(result);
        }
        public async Task<IActionResult> AcademyAllotmentTest()
        {
            AcademyAllotmentDto dto = new AcademyAllotmentDto();
            dto.Academy = (await _masterDataService.GetAccademyList()).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
            return View(dto);
        }
        [HttpGet]
        public async Task<IActionResult> LoadAllotmentArea(int academyId)
        {
            var programmes = await _masterDataService.GetProgrammeListByCCID(academyId);
            return PartialView("_AllotAreaPartial", programmes);
        }
        public async Task<IActionResult> LoadAllotmentArea2(int? KioskId, int? serviceId, int IsAlloted, int? CourseCategoryId, int? programId)
        {
            var programmes = await _masterDataService.GetCheckBoxForProgramAllotment(KioskId, serviceId, IsAlloted, CourseCategoryId, programId);
            return PartialView("_AllotAreaPartial", programmes);
        }
        public async Task<IActionResult> ProgramAllotmentTemp()
        {
            return View();
        }

    }

}
