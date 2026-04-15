using AisectOnline.Common.Users;
using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.Common;
using AisectOnline.Services.Modules.MasterData;
using AisectOnline.Services.Modules.StudentAssignment;
using AisectOnline.Services.Modules.Students;
using AisectOnline.Services.Modules.Users;
using AisectOnline.Data.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Caching.Distributed;

namespace AisectOnline.Web.Controllers
{
    public class StudentAssignmentController: BaseController
    {
  
        private readonly IAssignmentServices _AssignmentServices;
        public StudentDetailDto _StudentDetail;
        private readonly ICommonService _commonService;
        private readonly ISessionInitializer _sessionInit;
        public StudentAssignmentController(IAssignmentServices AssignmentServices, ILogger<StudentController> logger,ISessionInitializer sessionInit,IUserContextService userContext, ICommonService commonService) : base(logger, userContext, sessionInit)
        {
            _AssignmentServices = AssignmentServices;
            _commonService = commonService;
        }

        [HttpGet]
        public async Task<IActionResult> AssignmentPrcticalMarks(int KioskID)
        {
            StudentDetailDto _StudentDetails = new StudentDetailDto();
            TempData["KioskID"] = KioskID;
            _StudentDetails.listservice = await _AssignmentServices.GetServiceName(KioskID);
            return View(_StudentDetails);
        }

        [HttpGet]
        public JsonResult GetCategorybyID(int ServiceID)
        {
            if (TempData["KioskID"] != null)
            {
                int KioskID = Convert.ToInt32(TempData["KioskID"]);
                TempData.Keep("KioskID");
                //TempData["CourseKioskID"] = KioskID;
                var Courses = _AssignmentServices.GetCoursecategoryid(ServiceID, KioskID);
                return Json(Courses.Result);
            }
            else
            {
                return Json("KioskID not found");
            }
        }

        [HttpGet]
        public JsonResult GetAcdemyByCourse(int CategoryID, int ServiceID)
        {
           
            if (TempData["KioskID"] != null)
            {
                int KioskID = Convert.ToInt32(TempData["KioskID"]);
                TempData.Keep("KioskID"); // Preserve TempData["KioskID"] for the next request

             
                TempData["CourseKioskID"] = KioskID;
                var Courses = _AssignmentServices.GetCourseName(KioskID, CategoryID, ServiceID);
                return Json(Courses.Result);
            }
            else
            {
                return Json("KioskID not found");
            }
        }
        [HttpGet]
        public IActionResult GetStudents(int courseId, int ServiceID, int CategoryID)
        {
            List<StudentDetailDto> studentss = new List<StudentDetailDto>();
            int kioskid = Convert.ToInt32(TempData["CourseKioskIDD"]);
            TempData.Keep("kioskid"); // Preserve TempData["KioskID"] for the next request
            TempData["courseId"] = courseId;
            TempData["ServiceID"] = ServiceID;
            TempData["CategoryID"] = CategoryID;
            var students = _AssignmentServices.GetStudentsByCourseId(courseId, kioskid, ServiceID, CategoryID);
            return Json(students);
            //System.Threading.Thread.Sleep(2000);
            // return Json(studentss);
        }
        [HttpGet]


        public IActionResult GetStudentscourse(int CourseId, string ExamType)
        {

            var studentpapers = _AssignmentServices.GetStudentsByCourseAsync(CourseId, ExamType);

            int kioskid = Convert.ToInt32(TempData["CourseKioskID"]);

            int kioskidD = TempData["kioskid"] != null ? Convert.ToInt32(TempData["kioskid"]) : 0;

            // Preserve the kioskid in TempData for subsequent requests

            TempData.Keep("kioskid");
            TempData["CourseKioskIDD"] = kioskidD;
            //System.Threading.Thread.Sleep(2000);
            return Json(studentpapers.Result);
        }


        [HttpPost]
        public async Task<IActionResult> SaveStudentCourses([FromBody] List<students> studentData)
        {
            if (studentData == null || studentData.Count == 0)
            {
                return Json(new { success = false, message = "No student data received" });
            }

            int courseId = TempData["CourseID"] != null ? Convert.ToInt32(TempData["CourseID"]) : 0;
            int serviceId = TempData["ServiceID"] != null ? Convert.ToInt32(TempData["ServiceID"]) : 0;
            int categoryId = TempData["CategoryID"] != null ? Convert.ToInt32(TempData["CategoryID"]) : 0;

            TempData.Keep("CourseID");
            TempData.Keep("ServiceID");
            TempData.Keep("CategoryID");

            var type = studentData[0].TypeAssignment; // Assignment or Practical

            foreach (var student in studentData)
            {
                Console.WriteLine($"Processing StudentID: {student.StudentID}, RegNo: {student.RegistrationNo}, Course: {student.Course}");

                // Loop over subject names
                for (int i = 0; i < student.SubjectNames.Count; i++)
                {
                    if (!string.IsNullOrEmpty(student.SubjectNames[i]))
                    {
                        // Loop over courses
                        for (int j = 0; j < student.Courses.Count; j++)
                        {
                            if (!string.IsNullOrEmpty(student.Courses[j]))
                            {
                                if (type == "Assignment")
                                {
                                    int result = await _AssignmentServices.AssignmentSaveAsync(
                                        student.SubjectNames[j],
                                        student.Courses[j],
                                        student.StudentID,
                                        student.RegistrationNo,
                                        student.Course
                                    );

                                    Console.WriteLine($"AssignmentSaveAsync result: {result}");
                                }
                                else
                                {
                                    int result = await _AssignmentServices.PracticalSaveAsync(
                                        student.SubjectNames[j],
                                        student.Courses[j],
                                        student.StudentID,
                                        student.RegistrationNo,
                                        student.Course,
                                        student.KioskCode ?? string.Empty, // safe default
                                        student.SessionId != 0 ? student.SessionId : 192 // default sessionId if missing
                                    );

                                    Console.WriteLine($"PracticalSaveAsync result: {result}");
                                }
                            }
                        }
                    }

                    break; // ⚠️ in your code you `break` after 1 subject — do you want to keep that?
                }
            }

            // Refresh after save
            GetStudents(courseId, serviceId, categoryId);

            return Json(new { success = true, message = "Data saved successfully" });
        }



        [HttpPost]
        public async Task<IActionResult> SaveStudent([FromBody] students studentData)
        {
            if (studentData == null)
            {
                return Json(new { success = false, message = "No student data received" });
            }

            int result = 0;
            var type = studentData.TypeAssignment;

            // TempData values
            int courseId = TempData["CourseID"] != null ? Convert.ToInt32(TempData["CourseID"]) : 0;
            int serviceId = TempData["ServiceID"] != null ? Convert.ToInt32(TempData["ServiceID"]) : 0;
            int categoryId = TempData["CategoryID"] != null ? Convert.ToInt32(TempData["CategoryID"]) : 0;

            TempData.Keep("CourseID");
            TempData.Keep("ServiceID");
            TempData.Keep("CategoryID");

            // Debug logging
            Console.WriteLine($"Processing StudentID: {studentData.StudentID}, RegNo: {studentData.RegistrationNo}, Course: {studentData.Course}");

            try
            {
                for (int i = 0; i < studentData.SubjectNames.Count; i++)
                {
                    if (!string.IsNullOrEmpty(studentData.SubjectNames[i]))
                    {
                        for (int j = 0; j < studentData.Courses.Count; j++)
                        {
                            if (!string.IsNullOrEmpty(studentData.Courses[j]))
                            {
                                if (type == "Assignment")
                                {
                                    result = await _AssignmentServices.AssignmentSaveAsync(
                                        studentData.SubjectNames[j],
                                        studentData.Courses[j],
                                        studentData.StudentID,
                                        studentData.RegistrationNo,
                                        studentData.Course
                                    );
                                }
                                else
                                {
                                    result = await _AssignmentServices.PracticalSaveAsync(
                                        studentData.SubjectNames[j],
                                        studentData.Courses[j],
                                        studentData.StudentID,
                                        studentData.RegistrationNo,
                                        studentData.Course,
                                        studentData.KioskCode ?? string.Empty, // safe default
                                        studentData.SessionId != 0 ? studentData.SessionId : 192 // default if 0
                                    );
                                }
                            }
                        }
                    }

                    break; // ⚠ same as your code: only processes first subject. Do you want to keep this?
                }

                if (result > 0)
                {
                    GetStudents(courseId, serviceId, categoryId);
                    return Json(new { success = true, message = "Data saved successfully" });
                }
                else
                {
                    return Json(new { success = false, message = "Data save failed" });
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error saving student data: " + ex.Message);
                return Json(new { success = false, message = "An error occurred while saving data" });
            }
        }

    }
}
