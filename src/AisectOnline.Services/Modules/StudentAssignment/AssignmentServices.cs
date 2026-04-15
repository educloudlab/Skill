using AisectOnline.Data.Db;
using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.MasterData;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory.Database;

namespace AisectOnline.Services.Modules.StudentAssignment
{
    public class AssignmentServices:IAssignmentServices
    {
        private readonly AisectOnlineDbContext _context;
        public AssignmentServices(AisectOnlineDbContext context) => _context = context;
        public async Task<List<Servicess>> GetServiceName(int KioskID)
        {
            await _context.Database.OpenConnectionAsync();
            try
            {
                
                var KioskIds = new SqlParameter("@KioskId", KioskID);

                return await _context.Database
                    .SqlQueryRaw<Servicess>("EXEC up_GetServiceName @KioskId", KioskIds)
                    .ToListAsync() ?? new List<Servicess>();
            }         
            finally
            {
                await _context.Database.CloseConnectionAsync();
            }
        }
        public async Task<List<CourseCategory>> GetCoursecategoryid(int ServiceID, int KioskID)
        {
            await _context.Database.OpenConnectionAsync();
            try
            {
               
                var kioskServiceIds = new SqlParameter("@KioskServiceId", ServiceID);
                var kioskIds = new SqlParameter("@KioskID", KioskID);

                return await _context.CourseCategories
                    .FromSqlRaw("EXEC up_GetCategoryName @KioskServiceId, @KioskID", kioskServiceIds, kioskIds)
                    .ToListAsync();
            }
            finally
            {
                await _context.Database.CloseConnectionAsync();
            }
        }
       
        public async Task<List<CourseName>> GetCourseName(int KioskID, int CategoryID, int ServiceID)
        {
            await _context.Database.OpenConnectionAsync();
            try
            {
                var data = await _context.Database
                    .SqlQueryRaw<CourseName>(
                        "EXEC GetCourseName_Assignment @KioskID, @CategoryID, @ServiceID",
                        new SqlParameter("@KioskID", KioskID),
                        new SqlParameter("@CategoryID", CategoryID),
                        new SqlParameter("@ServiceID", ServiceID)
                    )
                    .ToListAsync();

                return data ?? new List<CourseName>();
            }
            finally
            {
                await _context.Database.CloseConnectionAsync();
            }
        }

        //public async Task<List<std>> GetStudentsByCourseId(int courseId, int KioskID, int ServiceID, int CategoryID)
        //{
        //    try
        //    {
        //        var results = new List<std>();

        //        using (var conn = _context.Database.GetDbConnection())
        //        {
        //            await conn.OpenAsync();
        //            using (var cmd = conn.CreateCommand())
        //            {
        //                cmd.CommandText = "GetStudentAssignmentName_Testing";
        //                cmd.CommandType = CommandType.StoredProcedure;

        //                cmd.Parameters.Add(new SqlParameter("@Courseid", courseId));
        //                cmd.Parameters.Add(new SqlParameter("@KioskID", KioskID));
        //                cmd.Parameters.Add(new SqlParameter("@ServiceID", ServiceID));
        //                cmd.Parameters.Add(new SqlParameter("@CategoryID", CategoryID));

        //                using (var reader = await cmd.ExecuteReaderAsync())
        //                {
        //                    while (await reader.ReadAsync())
        //                    {
        //                        results.Add(new std
        //                        {
        //                            StudentID = reader.GetInt32("StudentID"),
        //                            FirstName = reader.IsDBNull("FirstName") ? null : reader.GetString("FirstName"),
        //                            RequestNo = reader.GetString("RequestNo"),
        //                            Name = reader.GetString("Name")
        //                        });
        //                    }
        //                }
        //            }
        //        }
        //        return results;
        //    }
        //    catch(Exception ex)
        //    {
        //        throw;
        //    }
        //}
        public async Task<List<std>> GetStudentsByCourseId(int courseId, int KioskID, int ServiceID, int CategoryID)
        {
            await _context.Database.OpenConnectionAsync();
            try
            {
                var result = _context.Database
                    .SqlQueryRaw<std>(
                        "EXEC GetStudentAssignmentName_Testing @Courseid, @KioskID, @ServiceID, @CategoryID",
                        new SqlParameter("@Courseid", courseId),
                        new SqlParameter("@KioskID", KioskID),
                        new SqlParameter("@ServiceID", ServiceID),
                        new SqlParameter("@CategoryID", CategoryID)
                    )
                    .ToList();  // Sync inside async method

                return result ?? new List<std>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                await _context.Database.CloseConnectionAsync();
            }
        }


        //public async Task<List<CourseName>> GetStudentsByCourseId(int courseId, int KioskID, int ServiceID, int CategoryID)
        //{
        //    try
        //    {
        //        var courseIds = new SqlParameter("@Courseid", courseId);
        //        var kioskIds = new SqlParameter("@KioskID", KioskID);
        //        var serviceIds = new SqlParameter("@ServiceID", ServiceID);
        //        var categoryIds = new SqlParameter("@CategoryID", CategoryID);

        //        var result = await _context.Database
        //            .SqlQueryRaw<CourseName>(
        //                "EXEC GetStudentAssignmentName_Testing @Courseid, @KioskID, @ServiceID, @CategoryID",
        //                courseIds, kioskIds, serviceIds, categoryIds)
        //            .ToListAsync();

        //        return result ?? new List<CourseName>();
        //    }
        //    catch (Exception ex)
        //    {
        //        throw;
        //    }
        //}

        public async Task<List<ExamPapersNew>> GetStudentsByCourseAsync(int courseId, string examType)
        {
            await _context.Database.OpenConnectionAsync();
            try
            {
                var parameters = new[]
                   {
                    new SqlParameter("@CourseId", courseId),
                    new SqlParameter("@SubjectType", examType ?? (object)DBNull.Value)
                   };

                var result = await _context.Set<ExamPapersNew>()
                    .FromSqlRaw("EXEC GetStudentAssignmentNameCourse_Testing @CourseId, @SubjectType", parameters)
                    .ToListAsync();

                return result ?? new List<ExamPapersNew>();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                throw;
            }
            finally
            {
                await _context.Database.CloseConnectionAsync();
            }
        }



        public async Task<int> AssignmentSaveAsync(string papers, string assignmentMarks, int studentId, string registrationNo, string course)
        {
            int result = 0;
            try
            {
                // Define parameters safely
                var parameters = new[]
                {
                    new SqlParameter("@RegistrationNo", registrationNo ?? (object)DBNull.Value),
                    new SqlParameter("@SchemeId", DBNull.Value),
                    new SqlParameter("@SubjectName", papers ?? (object)DBNull.Value),
                    new SqlParameter("@AssignmentMarks", assignmentMarks ?? (object)DBNull.Value),
                    new SqlParameter("@PracticalMarks", DBNull.Value),
                    new SqlParameter("@KioskCode", DBNull.Value),
                    new SqlParameter("@Course", course ?? (object)DBNull.Value),
                    new SqlParameter("@SessionId", DBNull.Value)
                };
                // Execute stored procedure
                await _context.Database.ExecuteSqlRawAsync(
                    "EXEC InsertStudentAssignmentPractical @RegistrationNo, @SchemeId, @SubjectName, @AssignmentMarks, @PracticalMarks, @KioskCode, @Course, @SessionId",
                    parameters);

                result = 1; // success
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error: {ex.Message}");
                result = 0;
            }

            return result;
        }

        public async Task<int> PracticalSaveAsync(string papers,string practicalMarks,int studentId,string registrationNo,string course,string kioskCode,int sessionId)
        {
            int result = 0;
            try
            {
                var parameters = new[]
                {
                    new SqlParameter("@RegistrationNo", string.IsNullOrEmpty(registrationNo) ? DBNull.Value : (object)registrationNo),
                    new SqlParameter("@SubjectName", string.IsNullOrEmpty(papers) ? DBNull.Value : (object)papers),
                    new SqlParameter("@PracticalMarks", string.IsNullOrEmpty(practicalMarks) ? DBNull.Value : (object)practicalMarks),
                    new SqlParameter("@Course", string.IsNullOrEmpty(course) ? DBNull.Value : (object)course),
                    new SqlParameter("@KioskCode", string.IsNullOrEmpty(kioskCode) ? DBNull.Value : (object)kioskCode),
                    new SqlParameter("@SessionId", sessionId != 0 ? (object)sessionId : 1) // default to 1 if 0
             };

                    await _context.Database.ExecuteSqlRawAsync(
                    "EXEC UpdateStudentAssignmentPractical @RegistrationNo, @SubjectName, @PracticalMarks, @Course, @KioskCode, @SessionId",
                    parameters);
                    result = 1; // success
            }
            catch (SqlException ex)
            {
                Console.WriteLine($"SQL Error: {ex.Message}");
                result = -1; // SQL-specific error
            }
            catch (Exception ex)
            {
                Console.WriteLine($"General Error: {ex.Message}");
                result = -2; // general error
            }

            return result;
        }



    }
}
      



