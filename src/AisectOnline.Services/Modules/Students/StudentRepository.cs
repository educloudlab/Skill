using AisectOnline.Data.Db;
using AisectOnline.Data.Models;
using Azure.Core;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Data;
using System.Runtime.CompilerServices;
using System.Security.AccessControl;
using System.Threading;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AisectOnline.Services.Modules.Students;


public class StudentRepository : IStudentService
{
    private readonly AisectOnlineDbContext _db;
    private readonly IWebHostEnvironment _env;
    public StudentRepository(AisectOnlineDbContext db, IConfiguration configuration, IWebHostEnvironment env)
    {
        _db = db;
        _env = env;
    }

    public async Task<StudentInsertReturn> InsertStudent(StudentDto std)
    {
        try
        {
            var paramList = new List<SqlParameter>();
            paramList.Add(new SqlParameter("@StudentID", SqlDbType.Int)
            {
                Direction = ParameterDirection.InputOutput,
                Value = 0
            });

            var requestNoParam = new SqlParameter("@RequestNo", SqlDbType.NVarChar, 50)
            {
                Direction = ParameterDirection.InputOutput,
                Value = ""
            };
            paramList.Add(requestNoParam);

            paramList.Add(new SqlParameter("@FirstName", SqlDbType.NVarChar, 50) { Value = std.FirstName ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@LastName", SqlDbType.NVarChar, 50) { Value = std.LastName ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@FatherName", SqlDbType.NVarChar, 50) { Value = std.FatherName ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@MotherName", SqlDbType.NVarChar, 50) { Value = std.MotherName ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@DOB", SqlDbType.DateTime) { Value = std.Dob });
            paramList.Add(new SqlParameter("@Telephone", SqlDbType.NVarChar, 20) { Value = std.Telephone ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@ContactAddress", SqlDbType.NVarChar, 1000) { Value = std.ContactAddress ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@Pin", SqlDbType.NVarChar, 20) { Value = std.Pin ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@MobileNo", SqlDbType.NVarChar, 20) { Value = std.MobileNo ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@FaxNo", SqlDbType.NVarChar, 20) { Value = std.FaxNo ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@VillageTownCity", SqlDbType.NVarChar, 100) { Value = std.VillageTownCity ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@District", SqlDbType.Int) { Value = std.District });
            paramList.Add(new SqlParameter("@State", SqlDbType.Int) { Value = std.State });
            paramList.Add(new SqlParameter("@EmailAddress", SqlDbType.NVarChar, 50) { Value = std.EmailAddress ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@AcademicQualification", SqlDbType.Int) { Value = std.AcademicQualification });
            paramList.Add(new SqlParameter("@Sex", SqlDbType.Int) { Value = std.Sex });
            paramList.Add(new SqlParameter("@Category", SqlDbType.Int) { Value = std.Category });
            paramList.Add(new SqlParameter("@IsPhysicallyHandicapped", SqlDbType.Int) { Value = std.IsPhysicallyHandicapped });
            paramList.Add(new SqlParameter("@StudentBelongsTo", SqlDbType.Int) { Value = std.StudentBelongsTo });
            paramList.Add(new SqlParameter("@Medium", SqlDbType.Int) { Value = std.CourseMedium});
            paramList.Add(new SqlParameter("@OtherMedium", SqlDbType.NVarChar, 50) { Value = std.CourseMedium ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@MainSubject", SqlDbType.NVarChar, 50) { Value = std.MainSubject ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@YearOfPassing", SqlDbType.Int) { Value = std.YearOfPassing });
            paramList.Add(new SqlParameter("@Division", SqlDbType.NVarChar, 20) { Value = std.Division });
            paramList.Add(new SqlParameter("@MarksPercentage", SqlDbType.Decimal) { Precision = 22, Scale = 2, Value = std.MarksPercentage });
            paramList.Add(new SqlParameter("@BoardCode", SqlDbType.NVarChar, 50) { Value = std.BoardCode ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@Nationality", SqlDbType.Int) { Value = std.Nationality});
            paramList.Add(new SqlParameter("@MaritalStatus", SqlDbType.Int) { Value = std.MaritalStatus });
            paramList.Add(new SqlParameter("@Religion", SqlDbType.Int) { Value = std.Religion });
            paramList.Add(new SqlParameter("@WhetherMinority", SqlDbType.Int) { Value = std.WhetherMinority });
            paramList.Add(new SqlParameter("@SocialStatus", SqlDbType.Int) { Value = std.SocialStatus });
            paramList.Add(new SqlParameter("@WhetherKashmiriMigrant", SqlDbType.Int) { Value = std.WhetherKashmiriMigrant });
            paramList.Add(new SqlParameter("@WhetherPersonWithDisability", SqlDbType.Int) { Value = std.WhetherPersonWithDisability });
            paramList.Add(new SqlParameter("@NatureDisability", SqlDbType.Int) { Value = std.NatureDisability });
            paramList.Add(new SqlParameter("@OtherNatureDisability", SqlDbType.NVarChar, 100) { Value = std.OtherNatureDisability ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@EmploymentStatus", SqlDbType.Int) { Value = std.EmploymentStatus });
            paramList.Add(new SqlParameter("@AnnualScholarshipAmount", SqlDbType.Decimal) { Precision = 22, Scale = 2, Value = std.AnnualScholarshipAmount });
            paramList.Add(new SqlParameter("@FamilyIncomeYearly", SqlDbType.Decimal) { Precision = 22, Scale = 2, Value = std.FamilyIncomeYearly ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@DeptOfferingScholarship", SqlDbType.Int) { Value = std.DeptOfferingScholarship });
            paramList.Add(new SqlParameter("@BelowPovertyLine", SqlDbType.Int) { Value = std.BelowPovertyLine });
            paramList.Add(new SqlParameter("@KIOSKTypeID", SqlDbType.Int) { Value = std.KioskTypeID });
            paramList.Add(new SqlParameter("@CreatedBy", SqlDbType.Int) { Value = std.CreatedBy });
            paramList.Add(new SqlParameter("@ProgrammeID", SqlDbType.Int) { Value = std.Program });
            paramList.Add(new SqlParameter("@SessionID", SqlDbType.Int) { Value = std.Session });
            paramList.Add(new SqlParameter("@CourseFeeID", SqlDbType.Int) { Value = std.CourseFeeID});
            paramList.Add(new SqlParameter("@ServiceID", SqlDbType.Int) { Value = std.ServiceId });
            paramList.Add(new SqlParameter("@GovtEmployee", SqlDbType.Int) { Value = std.GovtEmployee ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@KIOSKID", SqlDbType.Int) { Value = std.Kioskid });
            paramList.Add(new SqlParameter("@BranchManager", SqlDbType.NVarChar, 100) { Value = std.BranchManager ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@StudentDocSubmitted", SqlDbType.NVarChar, 4000) { Value = "" });
            paramList.Add(new SqlParameter("@IsKIOSK", SqlDbType.Bit) { Value = 1 });
            paramList.Add(new SqlParameter("@AadharNo", SqlDbType.NVarChar, 20) { Value = std.AadharNo ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@DrivingLicenceNo", SqlDbType.NVarChar, 50) { Value = std.DrivingLicenceNo ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@DrivingLicenceType", SqlDbType.Int) { Value = std.DrivingLicenceType ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@CorresAddress", SqlDbType.NVarChar, 4000) { Value = std.CorresAddress ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@CorresPin", SqlDbType.NVarChar, 80) { Value = std.CorresPin ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@CorresVillageTownCity", SqlDbType.NVarChar, 400) { Value = std.CorresVillageTownCity ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@CorresDistrict", SqlDbType.Int) { Value = std.CorresDistrict ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@CorresState", SqlDbType.Int) { Value = std.CorresState?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@CourseMedium", SqlDbType.Int) { Value = std.CourseMedium1?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@CorresContactNo", SqlDbType.VarChar, 50) { Value = std.CorresContactNo ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@prospectusno", SqlDbType.NVarChar, 100) { Value = std.ProspectusNo ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@offlinebranchcode", SqlDbType.NVarChar, 100) { Value = std.OfflineBranchcode ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@LSCId", SqlDbType.Int) { Value = std.Lscid ?? (object)DBNull.Value });

            string sql = @"
EXEC up_InsertStudent 
    @StudentID = @StudentID OUTPUT,
    @RequestNo = @RequestNo OUTPUT,
    @FirstName = @FirstName,
    @LastName = @LastName,
    @FatherName = @FatherName,
    @MotherName = @MotherName,
    @DOB = @DOB,
    @Telephone = @Telephone,
    @ContactAddress = @ContactAddress,
    @Pin = @Pin,
    @MobileNo = @MobileNo,
    @FaxNo = @FaxNo,
    @VillageTownCity = @VillageTownCity,
    @District = @District,
    @State = @State,
    @EmailAddress = @EmailAddress,
    @AcademicQualification = @AcademicQualification,
    @Sex = @Sex,
    @Category = @Category,
    @IsPhysicallyHandicapped = @IsPhysicallyHandicapped,
    @StudentBelongsTo = @StudentBelongsTo,
    @Medium = @Medium,
    @OtherMedium = @OtherMedium,
    @MainSubject = @MainSubject,
    @YearOfPassing = @YearOfPassing,
    @Division = @Division,
    @MarksPercentage = @MarksPercentage,
    @BoardCode = @BoardCode,
    @Nationality = @Nationality,
    @MaritalStatus = @MaritalStatus,
    @Religion = @Religion,
    @WhetherMinority = @WhetherMinority,
    @SocialStatus = @SocialStatus,
    @WhetherKashmiriMigrant = @WhetherKashmiriMigrant,
    @WhetherPersonWithDisability = @WhetherPersonWithDisability,
    @NatureDisability = @NatureDisability,
    @OtherNatureDisability = @OtherNatureDisability,
    @EmploymentStatus = @EmploymentStatus,
    @AnnualScholarshipAmount = @AnnualScholarshipAmount,
    @FamilyIncomeYearly = @FamilyIncomeYearly,
    @DeptOfferingScholarship = @DeptOfferingScholarship,
    @BelowPovertyLine = @BelowPovertyLine,
    @KIOSKTypeID = @KIOSKTypeID,
    @CreatedBy = @CreatedBy,
    @ProgrammeID = @ProgrammeID,
    @SessionID = @SessionID,
    @CourseFeeID = @CourseFeeID,
    @ServiceID = @ServiceID,
    @GovtEmployee = @GovtEmployee,
    @KIOSKID = @KIOSKID,
    @BranchManager = @BranchManager,
    @StudentDocSubmitted = @StudentDocSubmitted,
    @IsKIOSK = @IsKIOSK,
    @AadharNo = @AadharNo,
    @DrivingLicenceNo = @DrivingLicenceNo,
    @DrivingLicenceType = @DrivingLicenceType,
    @CorresAddress = @CorresAddress,
    @CorresPin = @CorresPin,
    @CorresVillageTownCity = @CorresVillageTownCity,
    @CorresDistrict = @CorresDistrict,
    @CorresState = @CorresState,
    @CourseMedium = @CourseMedium,
    @CorresContactNo = @CorresContactNo,
    @prospectusno = @prospectusno,
    @offlinebranchcode = @offlinebranchcode,
    @LSCId = @LSCId;
";
            var lst = paramList;
            await _db.Database.ExecuteSqlRawAsync(sql, paramList.ToArray());
            return new StudentInsertReturn
            {
                studentID = Convert.ToInt32(paramList[0].Value),
                RequestNo = requestNoParam.Value?.ToString()
            };

        }
        catch (Exception ex)
        {
            throw;
        }
    }

    public async Task<List<StudentDto>> GetStudentsByYearAsync(int year)
    {
        return await _db.Students
            .Where(s => s.Dob.Year == year)
            .Select(s => new StudentDto
            {
                StudentId = s.StudentId,
                FirstName = s.FirstName,
                EmailAddress = s.EmailAddress,
                Dob = s.Dob
            }).ToListAsync();
    }
    public async Task<List<StudentFeeDto>> GetStudentCourseFeeAsync(DateTime? feeDate, int? FeeType, int kioskID)
    {
        try
        {
            
            var parameters = new[]
              {
                 new SqlParameter("@Date", feeDate ?? (object)DBNull.Value),
               new SqlParameter("@FeeTypeId", FeeType ?? (object)DBNull.Value),
                 new SqlParameter("@KIOSKID", kioskID)
            };
            return await ExecuteStoredProcedureForListItemsAsync("up_RptPendingStudentFees", parameters);
        }
        catch (Exception)
        {
            throw;
        }
    }

    public async Task<List<StudentFeeDto>> ExecuteStoredProcedureForListItemsAsync(
        string storedProcName,
        SqlParameter[] parameters)
    {
        try
        {
            if (_db == null)
                throw new InvalidOperationException("DbContext is not initialized.");

            var paramNames = parameters != null && parameters.Length > 0
                ? string.Join(", ", parameters.Select(p => "@" + p.ParameterName))
                : "";
            var args = parameters?.Select(p => p.Value).ToArray() ?? Array.Empty<object>();
            var sql = FormattableStringFactory.Create($"EXEC {storedProcName} {paramNames}", args);

            var result = await _db.Database.SqlQuery<StudentFeeDto>(sql).ToListAsync();

            return result;
        }
        catch (Exception ex)
        {
            Console.WriteLine($"[Error] Failed to execute stored procedure '{storedProcName}': {ex.Message}");
            throw;
        }
    }

    public Task<List<StudentDto>> GetAllAsync()
    {
        throw new NotImplementedException();
    }

    public Task<StudentDto?> GetByIdAsync(int id)
    {
        throw new NotImplementedException();
    }

    public Task<StudentDto> CreateAsync(StudentDto dto)
    {
        throw new NotImplementedException();
    }

    public Task<StudentDto> UpdateAsync(int id, StudentDto TDto)
    {
        throw new NotImplementedException();
    }

    public Task<bool> DeleteAsync(int id)
    {
        throw new NotImplementedException();
    }
        public async Task<List<StudentFeeDto>> GetStudentBalanceFeeList(DateTime? date, int feeType, int kioskID)
        {
            try
            {
                var parameters = new[]
                {
                new SqlParameter("@Date", (object?)date ?? DBNull.Value),
                new SqlParameter("@FeeTypeId", feeType == 0 ? (object)DBNull.Value : feeType),
                new SqlParameter("@KIOSKID", kioskID)
            };

                return await _db.Database
                    .SqlQuery<StudentFeeDto>(
                        $"EXEC up_RptPendingStudentFees @Date={parameters[0]}, @FeeTypeId={parameters[1]}, @KIOSKID={parameters[2]}")
                    .ToListAsync();
            }
            catch (Exception ex)
            {
                throw; 
            }
        }
    public async Task<IEnumerable<MasterList>> GetStudentDocuments(int masterId)
    {
        try
        {
            var param = new SqlParameter("@Id", masterId);

            return await _db.MasterLists
                .FromSqlRaw("EXEC up_GetStudentDocuments @Id", param)
                .ToListAsync();
        }
        catch (Exception)
        {
            throw;
        }
    }
    public async Task<bool> UploadDocumentsAsync(int studentId, string DocumentName, int kioskId, IFormFile file, int createdBy)
    {
        try
        {
            if (file == null || file.Length == 0)
                throw new Exception("File is missing or empty.");

            string uploadFolder = Path.Combine(_env.WebRootPath, "StudentDocuments");

            if (!Directory.Exists(uploadFolder))
                Directory.CreateDirectory(uploadFolder);

            var fileExt = Path.GetExtension(file.FileName);
            var originalName = Path.GetFileNameWithoutExtension(file.FileName);
            var originalFileName = $"{studentId}_{originalName}{fileExt}";
            var newFileName = $"{originalName}{fileExt}"; //$"{studentId}_{Guid.NewGuid()}{fileExt}";
            var filePath = Path.Combine(uploadFolder, originalFileName);

            // Save file to folder
            using (var stream = new FileStream(filePath, FileMode.Create))
            {
                await file.CopyToAsync(stream);
            }

            // Save DB record
            var document = new StudentDocumentuploaded
            {
                StudentId = studentId,
                KioskId = kioskId,
                //DocumentId = documentId,
                DocumentName = DocumentName, //originalName,
                FileName = newFileName,
                FilePath = $"/StudentDocuments/{newFileName}",
                CreatedOn = DateTime.Now,
                CreatedBy = createdBy,
                Status = "Uploaded",
                UploadedStatus = "Success",
                Remarks = "Uploaded via portal"
            };

            _db.StudentDocumentuploadeds.Add(document);
            await _db.SaveChangesAsync();

            return true; // success
        }
        catch (Exception ex)
        {
            // Log the actual exception for debugging
            //_logger.LogError(ex, $"Error uploading document for StudentId={studentId}, DocumentId={documentId}");
            return false; // failure
        }
    }
    public async Task<List<StudentPrintDto>> GetStudentsDetails(int studentID)
    {
        try
        {
            var studentIdParam = new SqlParameter("@StudentID", studentID);
            var requestNoParam = new SqlParameter("@RequestNo", DBNull.Value);
            var feeIdParam = new SqlParameter("@StudentCourseFeeID", DBNull.Value);

            var result = await _db.Database
                .SqlQueryRaw<StudentPrintDto>(
                    "EXEC up_SelectStudentRegDetailForPrint @StudentID, @RequestNo, @StudentCourseFeeID",
                    studentIdParam, requestNoParam, feeIdParam
                )
                .ToListAsync();
           return result;
        }
        catch(Exception ex)
        {
            throw ex;
        }
    }
    public async Task<List<StudentCourseDetails>> GetRegisteredStudentStatusAsync(
    string? requestNo,
    int? stateId,
    int? districtId,
    string? sessionId,
    string? name,
    int? kioskId,
    int? studentStatusId,
    int? courseId,
    string status)
    {
        try
        {
            var parameters = new[]
            {
            new SqlParameter("@RequestNo", requestNo ?? (object)DBNull.Value),
            new SqlParameter("@StateID", stateId ?? (object)DBNull.Value),
            new SqlParameter("@DistrictID", districtId ?? (object)DBNull.Value),
            new SqlParameter("@SessionID", sessionId ?? (object)DBNull.Value),
            new SqlParameter("@name", name ?? (object)DBNull.Value),
            new SqlParameter("@KIOSKID", kioskId ?? (object)DBNull.Value),
            new SqlParameter("@StudentStatusID", studentStatusId ?? (object)DBNull.Value),
            new SqlParameter("@CourseID", courseId ?? (object)DBNull.Value),
            new SqlParameter("@Status", status ?? (object)DBNull.Value)
        };
            _db.Database.SetCommandTimeout(300);
            return await _db.Database
                .SqlQueryRaw<StudentCourseDetails>(
                    "EXEC dbo.up_GetRegisteredStudentStatus2 @RequestNo, @StateID, @DistrictID, @SessionID, @name, @KIOSKID, @StudentStatusID, @CourseID, @Status",
                    parameters)
                .ToListAsync();
        }
        catch (InvalidOperationException ex) // Mapping error
        {
            // This ALWAYS contains the column name that failed
            var message = ex.InnerException?.Message ?? ex.Message;

            throw new Exception($"Column Mapping Error: {message}", ex);
        }
        catch (Exception ex)
        {
            throw new Exception($"General Error: {ex.Message}", ex);
        }
    }

    //public async Task<List<StudentCourseDetails>> GetRegisteredStudentStatusAsync(
    //string? requestNo,
    //int? stateId,
    //int? districtId,
    //string? sessionId,
    //string ?name,
    //int? kioskId,
    //int? studentStatusId,
    //int? courseId,
    //string status)
    //{
    //    try
    //    {
    //        var parameters = new[]
    //    {
    //    new SqlParameter("@RequestNo", requestNo ?? (object)DBNull.Value),
    //    new SqlParameter("@StateID", stateId ?? (object)DBNull.Value),
    //    new SqlParameter("@DistrictID", districtId ?? (object)DBNull.Value),
    //    new SqlParameter("@SessionID", sessionId ?? (object)DBNull.Value),
    //    new SqlParameter("@name", name ?? (object)DBNull.Value),
    //    new SqlParameter("@KIOSKID", kioskId ?? (object)DBNull.Value),
    //    new SqlParameter("@StudentStatusID", studentStatusId ?? (object)DBNull.Value),
    //    new SqlParameter("@CourseID", courseId ?? (object)DBNull.Value),
    //    new SqlParameter("@Status", status ?? (object)DBNull.Value)
    //};

    //        return await _db.Database.SqlQueryRaw<StudentCourseDetails>(
    //            "EXEC [dbo].[up_GetRegisteredStudentStatus2] @RequestNo, @StateID, @DistrictID, @SessionID, @name, @KIOSKID, @StudentStatusID, @CourseID, @Status",
    //            parameters
    //        ).ToListAsync();
    //    }

    //    catch(Exception ex)
    //    {
    //        throw;
    //    }
    //}


}
