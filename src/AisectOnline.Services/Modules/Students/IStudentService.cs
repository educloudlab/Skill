using AisectOnline.Data.Models;
using AisectOnline.Services.Base;
using Microsoft.AspNetCore.Http;
namespace AisectOnline.Services.Modules.Students;

public interface IStudentService : IBaseService<StudentDto>
{
    Task<List<StudentDto>> GetStudentsByYearAsync(int year);
    public Task<StudentInsertReturn> InsertStudent(StudentDto std);
    public Task<List<StudentFeeDto>> GetStudentCourseFeeAsync(DateTime? feeDate, int? FeeType, int kioskID);
    Task<List<StudentFeeDto>> GetStudentBalanceFeeList(DateTime? date, int feeType, int kioskID);

    Task<IEnumerable<MasterList>> GetStudentDocuments(int masterId);
    Task<bool> UploadDocumentsAsync(int studentId, string DocumentName, int kioskId, IFormFile file, int createdBy);
    Task<List<StudentPrintDto>> GetStudentsDetails(int StudentID);
    Task<List<StudentCourseDetails>> GetRegisteredStudentStatusAsync(
    string ?requestNo,
    int? stateId,
    int? districtId,
    string ?sessionId,
    string ?name,
    int? kioskId,
    int? studentStatusId,
    int? courseId,
    string status);
}