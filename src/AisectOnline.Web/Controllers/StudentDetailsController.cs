using AisectOnline.Services.Modules.Skill;
using AisectOnline.Services.Modules;
using AisectOnline.Common.Users;
using AisectOnline.Services.Modules.Common;
using AisectOnline.Services.Modules.MasterData;
using AisectOnline.Services.Modules.Students;
using AisectOnline.Services.Modules.Users;
using AisectOnline.Common;
using AisectOnline.Services.Modules.StudentAssignment;

using AisectOnline.Web.Controllers;
//using Grpc.Core;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.ViewEngines;
using Microsoft.Extensions.Caching.Memory;
using OfficeOpenXml;
using System.ComponentModel;
using System.Data;
using static DevExpress.Utils.SafeXml;


namespace AisectOnline.WebUI.Controllers
{
    [Route("StudentDetails")]
    public class StudentDetailsController : BaseController
    {

       
        private readonly IWebHostEnvironment _webHostEnvironment;
        private readonly ExcelUpload _excelService;
        private readonly ICommonService _commonService;
        private readonly IMemoryCache _cache;

        public StudentDetailsController(

        ILogger<StudentController> logger,
        IUserContextService userContext,
        ISessionInitializer sessionInit,
         ExcelUpload excelService,
        IWebHostEnvironment webHostEnvironment,
         ICommonService commonService,
         IMemoryCache cache)
       : base(logger, userContext, sessionInit)
        {
            _excelService = excelService;
            _webHostEnvironment = webHostEnvironment; 
            _commonService = commonService;
            _cache = cache;
        }

        [HttpGet("UploadExcel")]
        public ActionResult UploadExcel([FromQuery] string KioskID)
        {

            if (KioskID != null)
            {
                TempData["KioskID"] = KioskID;
                StudentDeatils _Student = new StudentDeatils();
                var dropdownItems = _excelService.GetDropdownItems();
                if (dropdownItems == null)
                {
                    dropdownItems = new List<State>();
                }
                ViewBag.DropdownItems = new SelectList(dropdownItems, "StateID", "StateName");
                return View(_Student);
            }
            else
            {
                return View();
            }
        }


        [HttpGet("GetState")]
        public JsonResult GetState(int ZoneId)
        {
            var State = _excelService.GetStateItems(ZoneId);
            return Json(State);
        }

        [HttpGet("GetDistricts")]
        public JsonResult GetDistricts(int stateId)
        {
            var districts = _excelService.GetDistricts(stateId);
            return Json(districts);
        }

        [HttpGet("GetKiosksByDistrict")]
        public JsonResult GetKiosksByDistrict(int districtId)
        {
            var kiosks = _excelService.GetKiosksByDistrictId(districtId);
            return Json(kiosks);
        }


        [HttpPost("saveUploadExcel")]
        public JsonResult saveUploadExcel(IFormFile file, int district, int State, string skp)
        {
            StudentDeatils _Student = new StudentDeatils();
            _Student.StateId = Convert.ToInt32(State);         
            _Student.DistrictId = Convert.ToInt32(district);
            _Student.SKP_Id = skp; 
            string result1 = "";
            if (file == null || file.Length == 0)
            {
                return null;
            }
            if (file != null)
            {              
                 using (var stream = file.OpenReadStream())
                {
                    result1 = _excelService.UploadExcelToDatabase(stream, _Student);

                    if(result1=="")
                    {
                        result1 = "Data is incorrect. Please Enter Correct SKP ID.";
                    }
                }
            } 
            return Json(result1);

        }

        [HttpGet("DownloadExcel")]
        public IActionResult DownloadExcel()
        {     
            string relativePath = "~/UploadExcel/TestExcel.xlsx";
            string filePath = Path.Combine(_webHostEnvironment.WebRootPath, "UploadExcel", "TestExcel.xlsx");

            if (!System.IO.File.Exists(filePath))
            {
                return NotFound("File not found.");
            }        
            return File(System.IO.File.ReadAllBytes(filePath), "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet", Path.GetFileName(filePath));
        }
        [HttpGet]
        public JsonResult DisplayData()
        {
            //var dataTable = await GetCurrentDataAsync();
            var dataTable = _excelService.GetCurrentData();
            var result = new
            {
                columns = dataTable.Columns.Cast<DataColumn>().Select(c => c.ColumnName).ToArray(),
                rows = dataTable.AsEnumerable().Select(row => row.ItemArray.Select(field => field.ToString()).ToArray()).ToArray()
            };
            return Json(result);
        }
        [HttpPost("DeleteAllRecords")]
        public ActionResult DeleteAllRecords(string id)
        {
            try
            {               
                var result = _excelService.DeleteStudentDeatilsbylotNo(id);
                return Json(new { success = true });
            }
            catch (Exception ex)
            {
                return Json(new { success = false, message = ex.Message });
            }
        }

        [HttpGet("StudentDetail")]
        public IActionResult StudentDetail()
        {
            // Initialize student details model


            if (TempData["KioskID"] != null)
            {

                var studentDetail = new StudentDeatils();

                // Fetch zone items and populate ViewBag
                var zoneItems = _excelService.GetZone() ?? new List<Zone>();
                ViewBag.Zone = new SelectList(zoneItems, "ZoneId", "ZoneName");

                var SectorItems = _excelService.GetSectors() ?? new List<Sectors>();
                ViewBag.Sector = new SelectList(SectorItems, "Id", "Sector");

                var EducationItems = _excelService.GetEducation() ?? new List<Education>();
                ViewBag.Education = new SelectList(EducationItems, "Id", "Qualification");

                // Initialize empty dropdowns for States, Districts, and SKPs
                ViewBag.States1 = new List<SelectListItem>();
                ViewBag.Districts = new List<SelectListItem>();
                ViewBag.SKPs = new List<SelectListItem>();

                // Return the view with the model
                return View(studentDetail);
            }
            else
            {
                return View();
            }
        }
       


        [HttpPost("setStudentDetail")]
        public IActionResult setStudentDetail(IFormCollection frm)
        {
              StudentDetail _StudentDetail = new StudentDetail();            
             _StudentDetail.SKP_Id = frm["SKPid"].ToString();
            _StudentDetail.Student_Name = frm["studname"].ToString();
            _StudentDetail.Father_Name = frm["fathername"].ToString();
            _StudentDetail.Mother_Name = frm["mothername"].ToString();
            _StudentDetail.GuardianName = frm["Guardian"].ToString();            
            _StudentDetail.Address = frm["address"].ToString();
            _StudentDetail.StateId = frm["Stateid"].ToString();
            _StudentDetail.DistrictId = frm["districtId"].ToString();
            _StudentDetail.City = frm["city"].ToString();
            _StudentDetail.PinCode = frm["pin"].ToString();
            _StudentDetail.Zone = frm["Zoneid"].ToString();            
            _StudentDetail.DOB = frm["dob"].ToString();
            _StudentDetail.Gender = frm["gender"].ToString();
            _StudentDetail.Category = frm["category"].ToString();
            _StudentDetail.Email = frm["email"].ToString();
            _StudentDetail.Mobile = frm["mobile"].ToString();
            _StudentDetail.AadharNo = frm["aadhar"].ToString();
            _StudentDetail.Education = frm["education"].ToString();
            _StudentDetail.Specialization = frm["Specialization"].ToString();            
            _StudentDetail.Medium = frm["medium"].ToString();
            _StudentDetail.Board = frm["board"].ToString();
            _StudentDetail.Year = frm["year"].ToString();
            _StudentDetail.Division = frm["division"].ToString();
            _StudentDetail.Project_Name = frm["projectname"].ToString();
            _StudentDetail.Funded_By = frm["Funded"].ToString();
            _StudentDetail.Assessment_Mode = frm["Assessment"].ToString();
            _StudentDetail.Project_FY = frm["projectfy"].ToString();
            _StudentDetail.Placement = frm["Placement"].ToString();
            _StudentDetail.Sector_Name = frm["Sector"].ToString();
            _StudentDetail.Course_Code_QP_Code = frm["coursecode"].ToString();
            _StudentDetail.Course_Name = frm["coursename"].ToString();
            _StudentDetail.Batch_Id = frm["batchid"].ToString();
            _StudentDetail.Aisect_Entity = frm["Entity"].ToString();
            _StudentDetail.StudentCertified = frm["StudentCertified"].ToString();
            _StudentDetail.StudentPlaced = frm["StudentPlaced"].ToString();
            _StudentDetail.Created_By = frm["createdby"].ToString();           
            int Result= _excelService.InsertStudentDeatils(_StudentDetail);
            if (Result == 1)
            {
                TempData["Result"] = "Student Details Successfully Saved";
            }
            else
            {
                TempData["Error"] = "Failed to Save Student Details.";
            }

            // Redirect to the StudentDetail action
            return RedirectToAction("StudentDetail");
        }

        [HttpGet("StudentDetailInformation")]
        public IActionResult StudentDetailInformation()
        {
            return View();
        }


        [HttpPost("StudentDetailInformation")]
        public  IActionResult StudentDetailInformation(IFormCollection frm)
        {
            StudentDetail _StudentDetail = new StudentDetail();
            _StudentDetail.Student_Name = frm["firstname"].ToString();
            return View();
            // return RedirectToAction("StudentDetails", new { name = StudentName });
        }
    


        [HttpGet("getUploadExcel")]
        public JsonResult getUploadExcel(int stateId, int districtId, int kioskID)
        {
            var kiosk = _excelService.GetUploadeData(stateId, districtId, kioskID);
            return Json(kiosk);
        }

        [HttpGet("StudentDashboard")]
        public ActionResult StudentDashboard()
        {
            return View();
        }


     

    
        [HttpPost("SubmitAndExport")]
        public IActionResult SubmitAndExport(IFormCollection frm)
        {
            DateTime? toDate = null;
            DateTime? fromDate = null;
            int stateName = string.IsNullOrEmpty(frm["stateDropdown"]) ? 0 : Convert.ToInt32(frm["stateDropdown"].ToString());
            int districtName = string.IsNullOrEmpty(frm["districtId"]) ? 0 : Convert.ToInt32(frm["districtId"].ToString());

            string skpName = frm["skpDropdownText"].ToString() ?? "";

            if (DateTime.TryParse(frm["fromdate"].ToString(), out DateTime parsedFromDate))
            {
                fromDate = parsedFromDate;
            }
            if (DateTime.TryParse(frm["todate"].ToString(), out DateTime parsedToDate))
            {
                toDate = parsedToDate;
            }

            // Validate the date range
            if (fromDate.HasValue && toDate.HasValue && fromDate > toDate)
            {
                TempData["msg"] = "Kindly select correct date format";
                return RedirectToAction("StudentData");
            }
            string Zone = frm["txtZone"].ToString();
            string fundedby = frm["txtfundedby"].ToString();
            string AisectEntity = frm["txtEntity"].ToString();
            string Assisment = frm["txtAssisment"].ToString();
             //Get the data as a list
            var studentDetails = _excelService.GetDataByDate(fromDate, toDate, stateName, districtName, skpName, Zone, fundedby, AisectEntity, Assisment);

            if (studentDetails.Count > 0)
            {
                var csvData = ConvertListToCsv(studentDetails);
                byte[] buffer = System.Text.Encoding.Unicode.GetBytes(csvData);
                Response.Headers.Add("Content-Disposition", "attachment; filename=StudentDetailsReport.csv");
                return File(buffer, "application/csv");
            }
            else
            {
                TempData["msg"] = "No records found.";
            }

            return RedirectToAction("StudentData");
        }

        [HttpGet("ConvertListToCsv")]
        private string ConvertListToCsv(List<StudentDetail> studentDetails)
        {
            var csv = new System.Text.StringBuilder();

            // Add header line

            csv.AppendLine("SKP_Id, RegistrationNo,  Student_Name, Father_Name, Mother_Name, Address, City ,DistrictName, Statename, PinCode, Zone, DOB, Gender, Category,Email,Mobile, AadharNo,Education,Specialization,Medium,Board,Year,Division, Project_Name ,Funded_By,Assessment_Mode,Project_FY,Sector_Name,Courde_Code_QP_Code,Course_Name,Batch_Id,Aisect_Entity,Created_By,Created_On,LotNo");
            //csv.AppendLine("SKP_Id,Student_Name,Father_Name,Mother_Name,Address,DistrictId,StateId,City,PinCode,Zone,DOB,Gender,Category,Email,Mobile,AadharNo,Education,Specialization,Medium,Board,Year,Division,Project_Name,Funded_By,Sector_Name,Course_Code_QP_Code,Course_Name,Batch_Id,Aisect_Entity,Created_By");

            // Add data lines
            foreach (var detail in studentDetails)
            {

                csv.AppendLine($"{detail.SKP_Id},{detail.RegistrationNo},{detail.Student_Name},{detail.Father_Name},{detail.Mother_Name},{detail.Address},{detail.City},{detail.DistrictId},{detail.StateId},{detail.PinCode},{detail.Zone},{detail.DOB},{detail.Gender},{detail.Category},{detail.Email},{detail.Mobile},{detail.AadharNo},{detail.Education},{detail.Specialization},{detail.Medium},{detail.Board},{detail.Year},{detail.Division},{detail.Project_Name},{detail.Funded_By},{detail.Assessment_Mode},{detail.Project_FY},{detail.Sector_Name},{detail.Course_Code_QP_Code},{detail.Course_Name},{detail.Batch_Id},{detail.Aisect_Entity},{detail.Created_By},{detail.Created_On},{detail.LotNo}");
            }

            return csv.ToString();
        }

        [HttpGet("StudentData")]
        public IActionResult StudentData()
        {

           
                StudentDeatils _Student = new StudentDeatils();

                var dropdownItems = _excelService.GetDropdownItems();
                if (dropdownItems == null)
                {
                    dropdownItems = new List<State>();
                }
                ViewBag.States = new SelectList(dropdownItems, "StateID", "StateName");
                ViewBag.Zone = new List<SelectListItem>();
                ViewBag.Districts = new List<SelectListItem>();
                ViewBag.SKPs = new List<SelectListItem>();
                return View(_Student);
         
        }




    }
}

