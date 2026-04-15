
using AisectOnline.Common.Users;
using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.Common;
using AisectOnline.Services.Modules.MasterData;
using AisectOnline.Services.Modules.Students;
using AisectOnline.Services.Modules.Users;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
//using Humanizer;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Newtonsoft.Json;
using System.Data;

namespace AisectOnline.Web.Controllers
{
    public class MasterController : BaseController
    {
        private readonly IMasterDataService _masterDataService;
        private readonly ICommonService _commonService;
        private readonly ISessionInitializer _sessionInit;
        public MasterController(IMasterDataService masterDataService, ILogger<StudentController> logger,
             ISessionInitializer sessionInit,
        IUserContextService userContext, ICommonService commonService) : base(logger, userContext, sessionInit)
        {
            _masterDataService = masterDataService;
            _commonService= commonService;

        }
        public async Task<IActionResult> ProgramAllotment()
        {
            return View();
        }
        
        public async Task<IActionResult> MasterDataList()
        {
            MasterDataListDto MDTL = new MasterDataListDto();
            MDTL.MasterDataTypeList = (await _masterDataService.GetMasterList()).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
            return View(MDTL);
        }
        

        public async Task<IActionResult> KioskServiceList()
        
        {
            KioskServiceListDto MDTL = new KioskServiceListDto();
            MDTL.KioskServiceList = (await _masterDataService.GetKioskServiceList()).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
            return View(MDTL);
        }

        [HttpPost]
        public async Task<IActionResult> CreateKioskService(
    [FromForm] int? MasterDataTypeId,
    [FromForm] string? ServiceName,
    [FromForm] bool? IsActive,
    [FromForm] bool? IsFinancialService,
    [FromForm] IFormFile? ImageFile)
        {
            try
            {

                if (!ModelState.IsValid) return BadRequest(ModelState);
                KioskServicesListDto dto = new KioskServicesListDto
                {
                    ServiceName = ServiceName,
                    IsActive = IsActive,
                    IsFinancialService = IsFinancialService == true ? 1 : 0,
                    KIOSKTypeID = MasterDataTypeId,
                    CreatedBy = 5609,
                    CreatedOn = DateTime.Now,
                    KIOSKServiceID = null,
                    ImagePath = ImageFile.FileName,

                };
                int Id = await _masterDataService.InsertOrUpdateKioskService(dto,0);

                string Imagename = $"Services{Id}";
                var Imagepath = await _commonService.SavePhotoAsync("ServiceLogo", ImageFile, Imagename);

                return Ok();
            }
            catch   (Exception ex)
            {
                throw ex;
            }
        }


        // ---------------- UPDATE ----------------
        [HttpPut]
        public async Task<IActionResult> UpdateKioskService(
          [FromForm] int? MasterDataTypeId,
          [FromForm] string? ServiceName,
          [FromForm] bool? IsActive,
          [FromForm] bool? IsFinancialService,
          [FromForm] IFormFile? ImageFile,
          [FromQuery] int ServiceID)
        {
            try
            {
                if (!ModelState.IsValid)
                    return BadRequest(ModelState);

                var dto = new KioskServicesListDto
                {
                    KIOSKServiceID = ServiceID,
                    ServiceName = ServiceName,
                    IsActive = IsActive ?? false,
                    IsFinancialService = IsFinancialService == true ? 1 : 0,
                    KIOSKTypeID = MasterDataTypeId,
                    UpdatedBy = 5609,
                    UpdatedOn = DateTime.Now,
                    ImagePath = ImageFile?.FileName
                };

                int id = await _masterDataService.InsertOrUpdateKioskService(dto, ServiceID);

                if (ImageFile != null && ImageFile.Length > 0)
                {
                    string imageName = $"Services{id}";
                    dto.ImagePath = await _commonService.SavePhotoAsync("ServiceLogo", ImageFile, imageName);
                }

                return Ok(new { id });
            }
            catch (Exception ex)
            {
                // Prefer logging instead of rethrowing
                return Problem(ex.Message);
            }
        }

                // ---------------- DELETE ----------------
                [HttpDelete]
        public async Task<IActionResult> DeleteMasterData(int MasterDataTypeId, [FromBody] KioskServicesListDto dto)
        {
            

            return Ok(new { message = "Deleted successfully" });
        }



        [HttpGet]
        public async Task<IActionResult> GetMasterDataList(int Id)
        {
            var data = await _masterDataService.GetMasterData(Id);
            ViewBag.MasterDataTypeId = Id;
            return Json(data);
        }
        [HttpGet]
        public async Task<IActionResult> GetKioskServiceList(int Id)
        {
            var data = await _masterDataService.GetKioskServiceData(Id);
            ViewBag.MasterDataTypeId = Id;
            return Json(data);
        }
        [HttpPost]
        public async Task<IActionResult> CreateMasterData([FromBody] ListItems dto, [FromQuery] int MasterDataTypeId)
        {
            if (dto == null)
                return BadRequest("Invalid data");

            try
            {

                var result = await _masterDataService.UpdateAndCreateMasterData(MasterDataTypeId,
              dto,
              5609,
               "Admin");
                if (result == -1)
                {
                    ViewData["EditError"] = "Duplicate entry";
                }
                else if (result == 0)
                {
                    ViewData["EditError"] = "Error occurs while processing your request.";
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }

       

        [HttpPut]   // ✅ PUT for update
        public async Task<IActionResult> UpdateMasterData([FromBody] ListItems dto, [FromQuery] int MasterDataTypeId)
        {
            if (dto == null)
                return BadRequest("Invalid data");

            try
            {

                var result = await _masterDataService.UpdateAndCreateMasterData(MasterDataTypeId,dto,5609,"Admin");
                if (result == -1)
                {
                    ViewData["EditError"] = "Duplicate entry";
                }
                else if (result == 0)
                {
                    ViewData["EditError"] = "Error occurs while processing your request.";
                }
                return Ok();
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }



        [HttpDelete]
        public async Task<IActionResult> DeleteMasterData([FromBody] ListItems dto,[FromQuery] int MasterDataTypeId)
        {
            try
            {
              var result=  await _masterDataService.DaleteMasterData(MasterDataTypeId, dto.ValueField);

                return Ok(new { success = true });
            }
            catch (Exception ex)
            {
                return BadRequest(new { error = ex.Message });
            }
        }
   
        [HttpGet]
        public async Task<IActionResult> MasterListType()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> _MasterListTypePartialView(int ID)
        {

            MasterListDto MasterListType = new MasterListDto();
            try
            {               
                var MasterTypeList = await _masterDataService.GetMasterTypeList(ID);
                return Ok(MasterTypeList);
                
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }


        [HttpPut]
        public async Task<IActionResult> Put(int key, string values)
        {
            try
            {
            
                var updatedEntity = new MasterListDto();
                JsonConvert.PopulateObject(values, updatedEntity);

                // Validation check
                if (!TryValidateModel(updatedEntity))
                    return BadRequest(ModelState);              
                var updated = await _masterDataService.UpdateMasterItemAsync(key, updatedEntity);

                if (updated == null)
                    return NotFound();

                return Ok(updated);
            }
            catch (Exception ex)
            {              
                return BadRequest(new { message = ex.Message });
            }
        }
        public async Task<IActionResult> Post(string values)
        {
            var entity = new MasterListDto();  // initially empty

            JsonConvert.PopulateObject(values, entity);  // fills properties from "values"

            if (!TryValidateModel(entity))
                return BadRequest(ModelState);

            var added = await _masterDataService.AddMasterItemAsync(entity); // entity is not null now
            return Ok(added);
        }

        [HttpDelete]
        public async Task<IActionResult> Delete(int key)
        {
            var deleted = await _masterDataService.DeleteMasterItemAsync(key);
            if (!deleted)
                return NotFound();

            return Ok();
        }

        //[HttpGet]
        //public async Task<IActionResult> CourseSession(int? sessionID, string role)
        //{
        //    List<SessionMaster> sessionMasters = new List<SessionMaster>();
        //    sessionMasters = await _masterDataService.GetSessionCourseList(sessionID, "Admin");
        //    return View(sessionMasters);
        //}
        [HttpGet]
        public async Task<IActionResult> CourseSession()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> _CourseSessionPartialView(int? sessionID, string role)
        {
            SessionMasterDtos SessionMasterList = new SessionMasterDtos();
            try
            {
                var SessionMList = await _masterDataService.GetSessionCourseListAsync(sessionID, "Admin");
                return Ok(SessionMList);
            }
            catch (Exception ex)
            {
                return StatusCode(500, $"Internal server error: {ex.Message}");
            }
        }

        [HttpGet]
        public async Task<IActionResult> _FeePartialView(DataSourceLoadOptions loadOptions, int? sessionID)
        {

            if (sessionID != null)
            {
                var allData = await _masterDataService.GetListLateFee(null, sessionID); // pass sessionId
                var filteredData = DataSourceLoader.Load(allData.AsQueryable(), loadOptions);
                return Ok(filteredData);
            }
            else
            {
                var allData = await _masterDataService.GetListLateFee(null, sessionID); // pass sessionId
                var filteredData = DataSourceLoader.Load(allData.AsQueryable(), loadOptions);
                return Ok(filteredData);
            }

        }


        public async Task<IActionResult> Get(int sessionID)
        {
            var details = await _masterDataService.GetListLateFee(null, sessionID);

            TempData["details"] = JsonConvert.SerializeObject(details);

            return RedirectToAction("_FeePartialView", details);
        }


        [HttpGet]
        public async Task<IActionResult> KioskServiceType()
        {
            var kioskTypes = await _masterDataService.GetKioskServiceList();
            var list = kioskTypes.Select(s => new {
                ValueField = s.ValueField,
                TextField = s.TextField
            }).ToList();

            return Json(list);
        }

        [HttpGet]
        public async Task<IActionResult> GetKioskServices(int kioskTypeId)
        {
            var Kioskservices = await _masterDataService.GetKioskServiceData(kioskTypeId);
            var list = Kioskservices
              .Select(s => new {
                  ValueField = s.KIOSKServiceID,
                  TextField = s.ServiceName
              })
              .ToList();

            return Json(list);
        }

        [HttpGet]
        public async Task<IActionResult> GetSessionList(int Id)
        {
            var Kioskservices = await _masterDataService.GetSessionList(Id);
            var list = Kioskservices
              .Select(s => new {
                  ValueField = s.ValueField,
                  TextField = s.TextField
              })
              .ToList();

            return Json(list);
        }


        [HttpGet]
        public async Task<IActionResult> CourseDesign()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> _ProgrammePartialView()
        {
            var programmes = await _masterDataService.GetProgrammeListAsync();
            return Json(programmes);
        }

        [HttpGet]
        public async Task<IActionResult> GetCourseList(int programmeId)
    => Ok(await _masterDataService.GetCourseListAsync(programmeId));

        [HttpGet]
        public async Task<IActionResult> GetCourseFeeList(int courseId, int? sessionId)
            => Ok(await _masterDataService.GetCourseFeeListAsync(courseId, sessionId));

        [HttpGet]
        public async Task<IActionResult> GetCourseFeeTypeList(int courseFeeId)
        {
            try
            {
                var data = await _masterDataService.GetCourseFeeTypeListAsync(courseFeeId);
                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching CourseFeeType list for {courseFeeId}", courseFeeId);
                return StatusCode(500, "Internal server error: " + ex.Message);
            }
        }


        [HttpGet]
        public async Task<IActionResult> GetFeeTypeDetailList(int courseFeeId)
        {
            try
            {
                // Here we call the EF-based service
                var data = await _masterDataService.GetFeeTypeDetailListAsync(courseFeeId);

                return Ok(data);
            }
            catch (Exception ex)
            {
                _logger.LogError(ex, "Error fetching fee type details for CourseFeeID {CourseFeeID}", courseFeeId);
                return StatusCode(500, "Internal server error");
            }
        }

        [HttpGet]
        public async Task<IActionResult> GetCourseCategories()
    => Ok(await _masterDataService.GetCourseCategoriesAsync());

        [HttpGet]
        public async Task<IActionResult> GetDepartments()
            => Ok(await _masterDataService.GetDepartmentsAsync());

        [HttpGet]
        public async Task<IActionResult> GetSkills()
            => Ok(await _masterDataService.GetSkillsAsync());

        [HttpGet]
        public async Task<IActionResult> GetStudyMaterialOptions()
            => Ok(await _masterDataService.GetStudyMaterialOptionsAsync());
        [HttpPost]
        public async Task<IActionResult> SaveProgramme([FromBody] ProgrammeDto programme)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var id = await _masterDataService.SaveProgrammeAsync(programme);
            return Ok(new { ProgrammeID = id });
        }


        [HttpPut]
        public IActionResult UpdateSession([FromBody] SessionMasterDtos model)
        {
            try
            {
                var updated = _masterDataService.UpdateSession(model);
                return Ok(updated);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult PostSession(string values)
        {
            try
            {
                var newSession = new SessionMasterDtos();
                JsonConvert.PopulateObject(values, newSession);
                var updatedSessionId = _masterDataService.InsertUpdateCourseSession(newSession);
                if (updatedSessionId > 0)
                {
                    return Ok(new { SessionID = updatedSessionId });
                }
                else
                {
                    return BadRequest(new { message = "Insert or update failed." });
                }
            }
            catch (Exception ex)
            {
                // Log error as appropriate (not shown here)
                return BadRequest(new { message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult FeeInsert(int sessionID, string values)
        {
            try
            {
                var newLateFeeMaster = new LateFeeMaster();
                JsonConvert.PopulateObject(values, newLateFeeMaster);
                if (!TryValidateModel(newLateFeeMaster))
                    return BadRequest(ModelState);
                var result = _masterDataService.AddLateFeeMaster(newLateFeeMaster);
                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }
        [HttpPut]
        public IActionResult FeeUpdate(int key, string values)
        {
            try
            {
                // Explicitly typed variable
                LateFeeMaster existing = _masterDataService.GetLateFeeMasterById(key);
                if (existing == null)
                    return NotFound(new { message = "Late Fee record not found." });

                // Apply updated values from JSON string to the existing object
                JsonConvert.PopulateObject(values, existing);

                if (!TryValidateModel(existing))
                    return BadRequest(ModelState);

                // Call service to update via stored procedure
                var result = _masterDataService.UpdateLateFeeMaster(existing);

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest(new { message = ex.Message });
            }
        }

    }
}