using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.StudentAssignment;

namespace AisectOnline.Services.Modules.StudentAssignment
{
    public interface IAssignmentServices
    {
        Task<List<Servicess>> GetServiceName(int KioskID);
        Task<List<CourseCategory>> GetCoursecategoryid(int ServiceID, int KioskID);

        Task<List<CourseName>> GetCourseName(int KioskID, int CategoryID, int ServiceID);
        Task<List<std>> GetStudentsByCourseId(int courseId, int KioskID, int ServiceID, int CategoryID);
        Task<List<ExamPapersNew>> GetStudentsByCourseAsync(int courseId, string examType);

        Task<int> AssignmentSaveAsync(string papers, string assignmentMarks, int studentId, string registrationNo, string course);
        Task<int> PracticalSaveAsync(string papers, string practicalMarks, int studentId, string registrationNo, string course, string kioskCode, int sessionId);
    }
}
