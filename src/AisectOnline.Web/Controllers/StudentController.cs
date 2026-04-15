using AisectOnline.Common.Helper;
using AisectOnline.Common.Users;
using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.Common;
//using AisectOnline.Services.Models;
using AisectOnline.Services.Modules.MasterData;
using AisectOnline.Services.Modules.Students;
using AisectOnline.Services.Modules.Users;
using AisectOnline.Web.Controllers;
using DevExpress.Utils.Serializing.Helpers;
using DevExtreme.AspNet.Data;
using DevExtreme.AspNet.Mvc;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Memory;
using Microsoft.OpenApi.Validations;
using Newtonsoft.Json;
using System.Drawing;
using System.Drawing.Imaging;
using System.Threading.Tasks;


//[Authorize]
public class StudentController : BaseController
{
    //private readonly IDistributedCache _cache;
    private readonly IMasterDataService _masterDataService;
    private readonly IStudentContextService _studentService;
    private readonly IStudentService _IstudentService;
    private readonly IWebHostEnvironment _env;
    private readonly ISessionInitializer _sessionInit;
    private readonly ICommonService _commonService;
    private readonly IMemoryCache _cache;

    public StudentController(

        ILogger<StudentController> logger,
        IUserContextService userContext,
        ISessionInitializer sessionInit,
        IStudentContextService studentService,
        IStudentService studentServices,
        IMasterDataService masterDataService,
        IWebHostEnvironment env, 
        ICommonService commonService,
        IMemoryCache cache)
        : base(logger, userContext, sessionInit)
    {
        _studentService = studentService;
        _masterDataService = masterDataService;
        _env = env;
        _IstudentService = studentServices;
        _commonService = commonService;
        _cache = cache;
    }

    public async Task<IActionResult> StudentRegistration1(int kioskID = 12429, int kioskTypeID = 1)
    {
        StudentRegistration1 std = new StudentRegistration1();
        std.kioskID = kioskID;
        std.kioskTypeID = kioskTypeID;
        std.Services = (await _masterDataService.GetServices(std.kioskID, std.kioskTypeID)).Select(s => new ListItems { TextField = s.TextField, ValueField = s.ValueField }).ToList();
        string captchaKey = Guid.NewGuid().ToString();
        ViewBag.CaptchaKey = captchaKey;
        return View(std);
    }



    [HttpPost]
    public async Task<IActionResult> StudentRegistration3(StudentRegistration1 std, string CaptchaKey)
    {
        try
        {
            if (string.IsNullOrEmpty(CaptchaKey) || !TempData.TryGetValue(CaptchaKey, out var expectedCaptchaObj))
            {
                ModelState.AddModelError(std.captcha, "CAPTCHA expired. Please refresh.");
            }
            else
            {
                string expectedCaptcha = expectedCaptchaObj?.ToString();
                if (!string.Equals(std.captcha?.Trim(), expectedCaptcha, StringComparison.Ordinal))
                {
                    ModelState.AddModelError(std.captcha, "Invalid CAPTCHA entered.");

                }
            }
            if (ModelState.IsValid)
            {
                var json = JsonConvert.SerializeObject(std);
                var encoded = Convert.ToBase64String(System.Text.Encoding.UTF8.GetBytes(json));
                return RedirectToAction("StudentRegistration", new { data = encoded });
            }
            else
            {
                // Identify and log the invalid fields
                var errorList = ModelState.Where(ms => ms.Value.Errors.Count > 0)
                                          .Select(ms => new
                                          {
                                              Field = ms.Key,
                                              Errors = ms.Value.Errors.Select(e => e.ErrorMessage).ToList()
                                          });
                // For displaying in UI (optional)
                ViewBag.Errors = errorList;
            }

        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, $"API error: {ex.Message}");
        }
        return RedirectToAction("StudentRegistration1", new { kioskID = 12429, kioskTypeID = 1 });
    }

    public async Task<IActionResult> StudentRegistration()
    {
        //int SkioskID = HttpContext.Session.GetInt32("KIOSKID")??0;
        int SkioskID = 12429;
        StudentDto std = new StudentDto();
        var userID = 5609;
        std.Kioskid = SkioskID;
        std.KioskTypeID = 1;
        std.ServiceId = 1;
        std.UserId = userID.ToString();
        std.CourseCategoryDropdown = (await _masterDataService.GetCourseCategory(std.KioskTypeID, std.ServiceId, std.Kioskid)).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
        std.StateDropdown = (await _masterDataService.GetAllStatesAsync()).Select(s => new ListItems { ValueField = s.StateId, TextField = s.StateName }).ToList();
        std.SexDropdown = (await _masterDataService.GetMasterDataAsync(2)).Select(s => new ListItems { ValueField = s.MasterListId, TextField = s.MasterValue?.ToString() ?? string.Empty }).ToList();
        std.MaritalStatusDropdown = (await _masterDataService.GetMasterDataAsync(7)).Select(s => new ListItems { ValueField = s.MasterListId, TextField = s.MasterValue?.ToString() ?? string.Empty }).ToList();
        std.CategoryDropdown = (await _masterDataService.GetMasterDataAsync(3)).Select(s => new ListItems { ValueField = s.MasterListId, TextField = s.MasterValue ?? string.Empty }).ToList();
        std.DrivingLicenceTypeDropdown = (await _masterDataService.GetMasterDataAsync(40)).Select(s => new ListItems { ValueField = s.MasterListId, TextField = s.MasterValue }).ToList();
        std.CourseMediumDropdown = (await _masterDataService.GetMasterDataAsync(5)).Select(s => new ListItems { ValueField = s.MasterListId, TextField = s.MasterValue }).ToList();
        std.CourseMedium1Dropdown = (await _masterDataService.GetMasterDataAsync(5)).Select(s => new ListItems { ValueField = s.MasterListId, TextField = s.MasterValue }).ToList();
        std.StudentBelongsToDropdown = (await _masterDataService.GetMasterDataAsync(4)).Select(s => new ListItems { ValueField = s.MasterListId, TextField = s.MasterValue }).ToList();
        std.NationalityDropdown = (await _masterDataService.GetMasterDataAsync(6)).Select(s => new ListItems { ValueField = s.MasterListId, TextField = s.MasterValue }).ToList();
        std.AcademicQualificationDropdown = (await _masterDataService.GetMasterDataAsync(1)).Select(s => new ListItems { ValueField = s.MasterListId, TextField = s.MasterValue }).ToList();
        std.SessionDropdown = (await _masterDataService.GetSessionRaw(null, std.KioskTypeID, std.ServiceId, userID)).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
        std.BranchManager = "raman|A848410 - Techno";
        std.RequestNo = "1233654";
        return View(std);
    }

    [HttpPost]
    public async Task<IActionResult> StudentRegistration2(StudentDto std, IFormFile photo)
    {
        try
        {

            if (!ModelState.IsValid)
            {
                var errorMessages = ModelState
    .Where(ms => ms.Value.Errors.Count > 0)
    .SelectMany(ms => ms.Value.Errors.Select(err => $"{ms.Key}: {err.ErrorMessage}"))
    .ToList();

                string allErrors = string.Join(Environment.NewLine, errorMessages);

                // Now you can log it, show in ViewBag, TempData, etc.
                System.Diagnostics.Debug.WriteLine(allErrors);

                //return View("Index", std);
            }

            std.CreatedOn = DateTime.Now;
            std.UpdatedOn = DateTime.Now;

            var Result = await _IstudentService.InsertStudent(std);
            var path = await _commonService.SavePhotoAsync("upload", photo, Result.RequestNo);
            TempData["SuccessMessage"] = "Student created successfully!";
            HttpContext.Session.SetInt32("StudentId", Result.studentID);
            return Json(new
            {
                success = true,
                requestNo = Result.RequestNo
            });
        }
        catch (Exception ex)
        {
            ModelState.AddModelError(string.Empty, $"Error: {ex.Message}");
            return View("Index", std);
        }
    }

    public async Task<List<DistrictMaster>> GetDistrictByStdID(int stdId)
    {
        try
        {
            var districts = await _masterDataService.GetDistrictByIDAsync(stdId);

            if (districts != null && districts.Any())
            {
                return districts;
            }
            else
            {
                return new List<DistrictMaster>();
            }

        }
        catch (Exception)
        {
            throw;
        }

    }


    public async Task<IActionResult> GetStudentCourseFeeData(int StudentID, [FromQuery] DataSourceLoadOptions loadOptions)

    {
        try
        {

            var students = await _studentService.GetStudentCourseFeeAsync(null, 1, 12429);

            if (students.Any())
            {
                var result = DataSourceLoader.Load(students, loadOptions);
                return Ok(result);
            }
            else
            {
                return NotFound("No students found");
            }


        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetProgrammes(int KioskTypeID, int SessionId, int CourseCategoryID, int KioskID)
    {
        try
        {
            var data = await _masterDataService.GetProgrammes(KioskTypeID, SessionId, CourseCategoryID, KioskID);
            StudentDto std = new StudentDto();
            std.ProgramDropdown = (data).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
            if (data != null && data.Count > 0)
            {
                return Json(std.ProgramDropdown);
            }
            else
            {
                return Json(new { success = false, message = "No data found." });
            }
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = $"Internal server error: {ex.Message}" });
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetCourseScheme(int sessionId, int kioskTypeId, int kioskServiceId)
    {
        try
        {
            StudentDto std = new StudentDto();
            var data = await _masterDataService.GetCourseScheme(sessionId, kioskTypeId, kioskServiceId);
            std.SchemeDropdown = (data).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
            if (data != null && data.Count > 0)
            {
                return Json(std.SchemeDropdown); // Return as JSON for AJAX calls
            }
            else
            {
                return Json(new { success = false, message = "No data found." });
            }
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = $"Internal server error: {ex.Message}" });
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetCourseyear(int SessionID, int ProgrammeID, int SchemeID, int KIOSKID)
    {
        try
        {
            var data = await _masterDataService.GetCourseyear(SessionID, ProgrammeID, SchemeID, KIOSKID);
            StudentDto std = new StudentDto();
            std.CourseCategoryDropdown = (data).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
            if (data != null && data.Count > 0)
            {
                return Json(std.CourseCategoryDropdown); // Return as JSON for AJAX calls
            }
            else
            {
                return Json(new { success = false, message = "No data found." });
            }
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = $"Internal server error: {ex.Message}" });
        }
    }
    [HttpGet]
    public JsonResult FillCourseFeeDetail1(int? valCourseFeeID, int? valSessionID, int? valStudentID, int? valKioskID)
    {
        try
        {
            if (valStudentID == null)
            {
                return Json(new { success = false, message = "Student ID is required." });
            }

            var listRegFeeHead = _masterDataService.listRegistrationFeeHeads(valCourseFeeID, valKioskID, valSessionID, valStudentID);

            return Json(new { success = true, data = listRegFeeHead });
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = "An error occurred.", error = ex.Message });
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetUniversity(int kioskId, int KioskTypeID)
    {
        try
        {
            StudentDto std = new StudentDto();
            var data = await _masterDataService.GetUniversity(kioskId, KioskTypeID);
            std.SchemeDropdown = (data).Select(s => new ListItems { ValueField = s.ValueField, TextField = s.TextField }).ToList();
            if (data != null && data.Count > 0)
            {
                return Json(std.SchemeDropdown); // Return as JSON for AJAX calls
            }
            else
            {
                return Json(new { success = false, message = "No data found." });
            }
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = $"Internal server error: {ex.Message}" });
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetFees(int valCourseFeeID, int valSessionID, int? valStudentID, int KioskId)
    {
        try
        {
            var data = await _masterDataService.GetFeesAsync(valCourseFeeID, KioskId, valSessionID, 0);

            if (data != null && data.Count > 0)
            {
                return Json(new { success = true, data });
            }
            else
            {
                return Json(new { success = false, message = "No data found." });
            }
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = $"Internal server error: {ex.Message}" });
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetOptionalSubject(int courseFeeId, int mediumId)
    {
        try
        {
            var data = await _masterDataService.GetOptionalSubject(courseFeeId, mediumId);

            if (data != null && data.Count > 0)
            {
                return Json(new { success = true, data });
            }
            else
            {
                return Json(new { success = false, message = "No data found." });
            }
        }
        catch (Exception ex)
        {
            return Json(new { success = false, message = $"Internal server error: {ex.Message}" });
        }
    }

    // GET: /Student
    [AllowAnonymous]
    /*public async Task<IActionResult> Index()
    {
        _sessionInit.InitializeSession(HttpContext);
        var students = await _studentService.GetAllAsync();
        return View(students);
    }
    */
    // GET: /Student/Details/5
    public async Task<IActionResult> Details(int id)
    {
        var student = await _studentService.GetByIdAsync(id);
        if (student == null) return NotFound();
        return View(student);
    }

    // GET: /Student/Create
    [Authorize(Roles = "Admin,SuperAdmin")]
    public IActionResult Create() => View();

    // POST: /Student/Create
    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public async Task<IActionResult> Create(StudentDto dto)
    {
        if (!ModelState.IsValid) return View(dto);
        await _studentService.CreateAsync(dto);
        return RedirectToAction(nameof(Index));
    }

    // GET: /Student/Edit/5
    [Authorize(Roles = "Admin,SuperAdmin")]
    public async Task<IActionResult> Edit(int id)
    {
        var student = await _studentService.GetByIdAsync(id);
        if (student == null) return NotFound();
        return View(student);
    }

    // POST: /Student/Edit/5
    [HttpPost]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public async Task<IActionResult> Edit(int id, StudentDto dto)
    {
        if (id != dto.StudentId) return BadRequest();
        if (!ModelState.IsValid) return View(dto);
        await _studentService.UpdateAsync(id, dto);
        return RedirectToAction(nameof(Index));
    }

    // GET: /Student/Delete/5
    [Authorize(Roles = "Admin,SuperAdmin")]
    public async Task<IActionResult> Delete(int id)
    {
        var student = await _studentService.GetByIdAsync(id);
        if (student == null) return NotFound();
        return View(student);
    }

    // POST: /Student/Delete/5
    [HttpPost, ActionName("Delete")]
    [ValidateAntiForgeryToken]
    [Authorize(Roles = "Admin,SuperAdmin")]
    public async Task<IActionResult> DeleteConfirmed(int id)
    {
        await _studentService.DeleteAsync(id);
        return RedirectToAction(nameof(Index));
    }

    [HttpGet]
    public IActionResult CaptchaImage(string key)
    {
        if (string.IsNullOrEmpty(key))
            return BadRequest();

        var captchaText = GenerateRandomText(5);
        TempData[key] = captchaText; // Store CAPTCHA with key

        var captchaImage = GenerateCaptchaImage(captchaText);
        return File(captchaImage, "image/png");
    }
    private string GenerateRandomText(int length)
    {
        var chars = Enumerable.Range(33, 94) // ASCII from ! to ~
            .Select(i => (char)i)
            .Where(c => char.IsLetterOrDigit(c))
            .ToArray();

        var random = new Random();
        return new string(Enumerable.Repeat(chars, length)
            .Select(s => s[random.Next(s.Length)]).ToArray());
    }
    private byte[] GenerateCaptchaImage(string captchaText)
    {
        using var bmp = new Bitmap(150, 40);
        using var gfx = Graphics.FromImage(bmp);
        gfx.Clear(Color.White);
        gfx.TextRenderingHint = System.Drawing.Text.TextRenderingHint.AntiAlias;

        using var font = new Font("Arial", 20, FontStyle.Bold);
        using var brush = new SolidBrush(Color.Black);

        // 10px left margin
        gfx.DrawString(captchaText, font, brush, 10, 5);

        using var ms = new MemoryStream();
        bmp.Save(ms, ImageFormat.Png);
        return ms.ToArray();
    }

    public async Task<IActionResult> _ExportToExcelPartial()
    => View();
    [HttpPost]
    public IActionResult SubmitSelectedStudents([FromBody] List<StudentFeeDto> selectedStudents)
    {
        if (selectedStudents == null || selectedStudents.Count == 0)
            return BadRequest("No students submitted.");
        return Ok("Students submitted successfully.");
    }
    [HttpGet]
    public async Task<IActionResult> BulkFeePayment()
    {
        return View();
    }

    [HttpGet]
    public async Task<IActionResult> _BulkFeePartialView(int feeType)
    {
        StudentCourseFee StudentCourseFee = new StudentCourseFee();
        try
        {
            int kioskID = 12429;
            DateTime? datedate = null;
            var studentFeeList = await _IstudentService.GetStudentBalanceFeeList(datedate, feeType, kioskID);
            return Ok(studentFeeList);
        }
        catch (Exception ex)
        {
            return StatusCode(500, $"Internal server error: {ex.Message}");
        }
    }

    [HttpPut]
    public IActionResult Put(int key, string values)
    {

        return Ok();
    }


    //[HttpPost]
    //public IActionResult Post(string values)
    //{
    //    var newEmployee = new Employee();
    //    JsonPopulateObjectExtensions.PopulateObject(values, newEmployee);

    //    if (!TryValidateModel(newEmployee))
    //        return BadRequest(ModelState.GetFullErrorMessage());

    //    _data.Employees.Add(newEmployee);
    //    _data.SaveChanges();

    //    return Ok();
    //}

    //[HttpPut]
    //public IActionResult Put(int key, string values)
    //{
    //    var employee = _data.Employees.First(a => a.ID == key);
    //    JsonPopulateObjectExtensions.PopulateObject(values, employee);

    //    if (!TryValidateModel(employee))
    //        return BadRequest(ModelState.GetFullErrorMessage());

    //    _data.SaveChanges();

    //    return Ok();
    //}

    //[HttpDelete]
    //public void Delete(int key)
    //{
    //    var employee = _data.Employees.First(a => a.ID == key);
    //    _data.Employees.Remove(employee);
    //    _data.SaveChanges();
    //}



    [HttpGet]
    public IActionResult StudentsDocument(int? stdId, string flag)
    {
        try
        {
            int studentId = 0;
            if (flag == "new")
            {
                studentId = HttpContext.Session.GetInt32("StudentId") ?? 0;
            }
            else
            {
                studentId = stdId ?? 0;
            }
            TempData["StudentID"] = studentId;
            return PartialView("StudentsDocument");
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    public async Task<IActionResult> GetStudentDocuments(int stdId)
    {
        try
        {

            var documents = await _IstudentService.GetStudentDocuments(stdId);

            var result = documents.Select(d => new
            {
                documentId = d.MasterListId,
                documentName = d.MasterValue
            });

            return Json(result);
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpPost]
    public async Task<IActionResult> UploadMultipleDocuments([FromForm] int studentId, [FromForm] int kioskId, [FromForm] List<DocumentUploadDto> documents, int CreatedBy)
    {
        try
        {
            if (documents == null || documents.Count == 0)
                return Json(new { success = false, message = "No documents received." });
            List<string> failedDocs = new List<string>();
            foreach (var doc in documents)
            {
                bool success = await _IstudentService.UploadDocumentsAsync(studentId, doc.DocumentId, kioskId, doc.File, 1);
                if (!success)
                {
                    failedDocs.Add($"Document ID {doc.DocumentId} failed to upload.");
                }
            }
            if (failedDocs.Any())
            {
                return Json(new
                {
                    success = false,
                    message = "Some documents failed to upload.",
                    errors = failedDocs
                });
            }

            return Json(new { success = true, message = "All documents uploaded successfully." });
        }
        catch (Exception ex)
        {
            throw ex;
        }
    }

    [HttpGet]
    public async Task<IActionResult> _StudentsSummary()
    {
        int studentId = HttpContext.Session.GetInt32("StudentId") ?? 0;
        var std = await _IstudentService.GetStudentsDetails(studentId);
        var student = std.FirstOrDefault();

        return PartialView("_StudentsSummary", student);
    }
    public async Task< IActionResult> ManageStudent1()
    {
        var model = new StudentSearchDto();
        model.StatusList = (await _masterDataService.GetStatus())
         .Select(s => new ListItems
         {
             ValueField = s.ValueField,
             TextField = s.TextField
         })
         .ToList();
        model.SessionList = (await _masterDataService.GetSessions())
         .Select(s => new ListItems
         {
             ValueField = s.ValueField,
             TextField = s.TextField
         })
         .ToList();
        return View(model);
    }
    [HttpPost]
    public IActionResult Search(string? Name,string? RegistrationNumber,string? Status,string? CenterCode,string? Course,List<string>? Session)
    {
        var data = new List<StudentResult1>
    {
        new StudentResult1
        {
            Id = 1,
            Name = "Yash",
            RegistrationNumber = "1001",
            Status = "Active",
            CenterCode = "C01",
            Course = "B.Sc",
            Session = "2023-24"
        },
        new StudentResult1
        {
            Id = 2,
            Name = "Ravi",
            RegistrationNumber = "1002",
            Status = "Inactive",
            CenterCode = "C02",
            Course = "B.A",
            Session = "2024-25"
        }
    };

        // ✅ Apply filters based on posted parameters
        var filtered = data.Where(x =>
            (string.IsNullOrEmpty(Name) || x.Name.Contains(Name)) &&
            (string.IsNullOrEmpty(RegistrationNumber) || x.RegistrationNumber.Contains(RegistrationNumber)) &&
            (string.IsNullOrEmpty(Status) || x.Status == Status) &&
            (string.IsNullOrEmpty(CenterCode) || x.CenterCode.Contains(CenterCode)) &&
            (string.IsNullOrEmpty(Course) || x.Course.Contains(Course)) &&
            (Session == null || Session.Count == 0 || Session.Contains(x.Session))
        ).ToList();

        return PartialView("_StudentSearchGrid", filtered);
    }

    [HttpGet]
    public async Task<IActionResult> GetKiosks(DataSourceLoadOptions loadOptions)
    {
        try
        {

            var kiosksQuery = await CacheHelper.GetOrCreateAsync(
                _cache,
                "Kiosk_All",
                async () => await _masterDataService.GetKiosks()
            );

            var result = DataSourceLoader.Load(kiosksQuery, loadOptions);
            return Json(result);
        }
        catch(Exception ex)
        {
            throw;
        }
    }
    [HttpGet]
    public async Task<IActionResult> GetCoursesByCentreCodeID(int? id,int KioskId)
    {
        try
        {
            var data = await _masterDataService.GetCoursesByCentreCodeID(null,KioskId);
            if (data != null && data.Count > 0)
            {
                return Json(data); 
            }
            else
            {
                return Json(new { success = false, message = "No data found." });
            }
        }
        catch(Exception ex)
        {
            throw;
        }
    }
}





