using AisectOnline.Services.Base;
namespace AisectOnline.Services.Modules.Students;

public interface IStudentContextService : IBaseService<StudentDto>
{
    Task<List<StudentDto>> GetStudentsByYearAsync(int year);
    public Task<StudentInsertReturn> InsertStudent(StudentDto std);
    public Task<List<StudentFeeDto>> GetStudentCourseFeeAsync(DateTime? feeDate, int? FeeType, int kioskID);
    
}