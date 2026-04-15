
using AisectOnline.Services.Base;
using AisectOnline.Data.Db;
using AisectOnline.Data.Models;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Data;

namespace AisectOnline.Services.Modules.Students;

public class StudentContextService : BaseService<Student, StudentDto>, IStudentContextService
{
    public StudentContextService(AisectOnlineDbContext db, ILogger<StudentContextService> logger)
        : base(db, logger) { }
         
    /*public async Task<List<StudentFeeDto>> GetStudentCourseFeeAsync(DateTime? feeDate, int? feeType, int kioskID)
    {
        // example implementation
        return await _db.StudentCourseFees
            .Where(f => (!feeDate.HasValue || f.Date == feeDate)
                     && (!feeType.HasValue || f.FeeTypeId == feeType)
                     && f.KioskId == kioskID)
            .Select(f => new StudentFeeDto { /* map properties */ /*})
            .ToListAsync();
    } */

    protected override StudentDto ToDto(Student entity)
        => new StudentDto
        {
            /*Id = entity.Id,
            Name = entity.Name,
            Email = entity.Email,
            DateOfBirth = entity.DateOfBirth,
            Address = entity.Address*/
        };

    protected override Student ToEntity(StudentDto dto)
        => new Student
        {
           /* Id = dto.Id,
            Name = dto.Name,
            Email = dto.Email,
            DateOfBirth = dto.DateOfBirth,
            Address = dto.Address */
        };

    protected override void UpdateEntity(Student entity, StudentDto dto)
    {
        /* entity.Name = dto.Name;
        entity.Email = dto.Email;
        entity.DateOfBirth = dto.DateOfBirth;
        entity.Address = dto.Address; */
    }





    //private readonly string _connectionString;
    //public StudentContextService(AisectOnlineDbContext db, IConfiguration configuration)
    //{
    //    _db = db;
    //    _connectionString = configuration.GetConnectionString("DefaultConnection") ?? throw new InvalidOperationException("Connection string 'DefaultConnection' not found.");
    //}

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
            paramList.Add(new SqlParameter("@Medium", SqlDbType.Int) { Value = std.CourseMedium });
            paramList.Add(new SqlParameter("@OtherMedium", SqlDbType.NVarChar, 50) { Value = std.CourseMedium ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@MainSubject", SqlDbType.NVarChar, 50) { Value = std.MainSubject ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@YearOfPassing", SqlDbType.Int) { Value = std.YearOfPassing });
            paramList.Add(new SqlParameter("@Division", SqlDbType.NVarChar, 20) { Value = std.Division });
            paramList.Add(new SqlParameter("@MarksPercentage", SqlDbType.Decimal) { Precision = 22, Scale = 2, Value = std.MarksPercentage });
            paramList.Add(new SqlParameter("@BoardCode", SqlDbType.NVarChar, 50) { Value = std.BoardCode ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@Nationality", SqlDbType.Int) { Value = std.Nationality });
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
            paramList.Add(new SqlParameter("@CourseFeeID", SqlDbType.Int) { Value = std.CourseFeeID });
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
            paramList.Add(new SqlParameter("@CorresState", SqlDbType.Int) { Value = std.CorresState ?? (object)DBNull.Value });
            paramList.Add(new SqlParameter("@CourseMedium", SqlDbType.Int) { Value = std.CourseMedium1 ?? (object)DBNull.Value });
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

    public Task<List<StudentFeeDto>> GetStudentCourseFeeAsync(DateTime? feeDate, int? FeeType, int kioskID)
    {
        throw new NotImplementedException();
    }
    /*public async Task<List<StudentFeeDto>> GetStudentCourseFeeAsync(DateTime? feeDate, int? FeeType, int kioskID)
{
   try
   {
       _db.Database.SetCommandTimeout(180);

       var parameters = new[]
         {
            new SqlParameter("@Date", feeDate ?? (object)DBNull.Value),
          new SqlParameter("@FeeTypeId", FeeType ?? (object)DBNull.Value),
            new SqlParameter("@KIOSKID", kioskID)
       };
       return await ExecuteStoredProcedureForListItemsAsync("up_RptPendingStudentFees", parameters);


       //return data;
   }
   catch (Exception)
   {
       throw;
   }
}

/*
public async Task<List<StudentFeeDto>> ExecuteStoredProcedureForListItemsAsync(
string storedProcName,
SqlParameter[] parameters,
string connectionString = null,
DbContext dbContext = null)
{
   var results = new List<StudentFeeDto>();

   try
   {
       string connStr = _connectionString;
       if (string.IsNullOrEmpty(connStr))
           throw new InvalidOperationException("No valid connection string or DbContext provided.");

       await using var connection = new SqlConnection(connStr);
       await connection.OpenAsync();

       await using var command = new SqlCommand(storedProcName, connection)
       {
           CommandType = CommandType.StoredProcedure
       };

       if (parameters != null && parameters.Length > 0)
           command.Parameters.AddRange(parameters);

       await using var reader = await command.ExecuteReaderAsync();
       while (await reader.ReadAsync())
       {
           var item = new StudentFeeDto
           {
               Seq_No = reader["Seq_No"] != DBNull.Value ? Convert.ToInt32(reader["Seq_No"]) : 0,
               RequestNo = reader["RequestNo"]?.ToString(),
               StudentID = reader["StudentID"] != DBNull.Value ? Convert.ToInt32(reader["StudentID"]) : 0,
               StudentName = reader["StudentName"]?.ToString(),
               FatherName = reader["FatherName"]?.ToString(),

               CourseID = reader["CourseID"] != DBNull.Value ? Convert.ToInt32(reader["CourseID"]) : null,
               CourseName = reader["CourseName"]?.ToString(),

               ProgrammeID = reader["ProgrammeID"] != DBNull.Value ? Convert.ToInt32(reader["ProgrammeID"]) : null,
               ProgrammeName = reader["ProgrammeName"]?.ToString(),

               FeeType = reader["FeeType"]?.ToString(),
               month = reader["month"]?.ToString(),

               Fee = reader["Fee"] != DBNull.Value ? Convert.ToDecimal(reader["Fee"]) : null,
               LateFee = reader["LateFee"] != DBNull.Value ? Convert.ToDecimal(reader["LateFee"]) : null,
               TotalFee = reader["TotalFee"] != DBNull.Value ? Convert.ToDecimal(reader["TotalFee"]) : null,
               serviceTax = reader["serviceTax"] != DBNull.Value ? Convert.ToDecimal(reader["serviceTax"]) : null,

               SessionName = reader["SessionName"]?.ToString(),
               SessionID = reader["SessionID"] != DBNull.Value ? Convert.ToInt32(reader["SessionID"]) : null,

               EmailAddress = reader["EmailAddress"]?.ToString(),
               StudentCourseFeeID = reader["StudentCourseFeeID"] != DBNull.Value ? Convert.ToInt32(reader["StudentCourseFeeID"]) : 0,

               ServiceID = reader["ServiceID"] != DBNull.Value ? Convert.ToInt32(reader["ServiceID"]) : null,

               MobileNo = reader["MobileNo"]?.ToString(),
               Scheme = reader["Scheme"]?.ToString(),
               ProspectusNo = reader["ProspectusNo"]?.ToString(),
               OfflineBranchcode = reader["OfflineBranchcode"]?.ToString()
           };

           results.Add(item);
       }

       return results;
   }
   catch (Exception ex)
   {
       Console.WriteLine($"[Error] Failed to execute stored procedure '{storedProcName}': {ex.Message}");
       throw;
   }
}
/*
protected override StudentDto ToDto(Student entity)
{
   throw new NotImplementedException();
}

protected override Student ToEntity(StudentDto dto)
{
   throw new NotImplementedException();
}

protected override void UpdateEntity(Student entity, StudentDto dto)
{
   throw new NotImplementedException();
}*/
}
