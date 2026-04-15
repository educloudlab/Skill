using AisectOnline.Data.Db;
using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.Students;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel;
using System.Data;
using System.Data.Common;
using System.Data.SqlTypes;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;

namespace AisectOnline.Services.Modules.MasterData
{
    public class MasterDataService : IMasterDataService
    {

        private readonly AisectOnlineDbContext _context;
        public MasterDataService(AisectOnlineDbContext context) => _context = context;
        /// Meathod Get Master data from stored procedure 

        /// </summary>
        /// <param ></param>
        /// <returns></returns>
        public async Task<List<ListItems>> ExecuteStoredProcedureForListItemsAsync(
       string storedProcName,
       SqlParameter[] parameters)
        {
            try
            {
                var paramStrings = new List<string>();
                var paramValues = new List<object>();

                for (int i = 0; i < parameters.Length; i++)
                {
                    var name = parameters[i].ParameterName;
                    paramStrings.Add($"{name} = {{{i}}}");
                    paramValues.Add(parameters[i].Value);
                }

                var sqlFormat = $"EXEC {storedProcName} {string.Join(", ", paramStrings)}";
                var interpolated = FormattableStringFactory.Create(sqlFormat, paramValues.ToArray());

                var result = await _context.Database
                    .SqlQuery<ListItems>(interpolated)
                    .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                Console.WriteLine($"[Error] Failed to execute stored procedure '{storedProcName}': {ex.Message}");
                throw;
            }
        }


        public async Task<List<StateMaster>> GetAllStatesAsync()
        {
            return await _context.StateMasters
                .OrderBy(s => s.StateId)
                .Select(s => new StateMaster
                {
                    StateId = s.StateId,
                    StateName = s.StateName
                })
                .ToListAsync();
        }

        public async Task<List<DistrictMaster>> GetDistrictByIDAsync(int stId)
        {
            return await _context.DistrictMasters
                .Where(s => s.StateId == stId)
                .OrderBy(s => s.DistrictId)
                .Select(s => new DistrictMaster
                {
                    DistrictId = s.DistrictId,
                    DistrictName = s.DistrictName
                })
                .ToListAsync();
        }
        public async Task<List<MasterList>> GetMasterDataAsync(int id)
        {
            return await _context.MasterLists
                .Where(s => s.MasterListTypeId == id)
                .OrderBy(s => s.MasterListId)
                .Select(s => new MasterList
                {
                    MasterValue = s.MasterValue,
                    MasterListId = s.MasterListId,
                })
                .ToListAsync();
        }

        public async Task<List<ListItems>> GetSessionRaw(int? sessionId, int kioskTypeId, int kioskServiceId, int userId)
        {
            try
            {
                var parameters = new[]
                {
        new SqlParameter("@ID1", sessionId ?? (object)DBNull.Value),
        new SqlParameter("@ID2", kioskTypeId),
        new SqlParameter("@ID3", kioskServiceId),
        new SqlParameter("@ID4", userId)
    };

                // Call your reusable method here

                var data = await ExecuteStoredProcedureForListItemsAsync("up_SelectSessionMaster", parameters);
                return data;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<ListItems>> GetCourseCategory(int kioskTypeId, int kioskServiceId, int kioskId)
        {
            try
            {
                var parameters = new[]
          {
                    new SqlParameter("@ID1", DBNull.Value),
                    new SqlParameter("@ID2", kioskTypeId),
                    new SqlParameter("@ID3", kioskServiceId),
                    new SqlParameter("@ID4", kioskId)
                };
                return await ExecuteStoredProcedureForListItemsAsync("up_SelectStudentCourseCategoryByKiosk", parameters);
            }
            catch (Exception EX)
            {
                throw;
            }
        }

        public async Task<List<ListItems>> GetProgrammes(int kioskTypeId, int sessionId, int courseCategoryId, int kioskId)
        {
            try
            {
                var parameters = new[]
            {
                    new SqlParameter("@ID1", kioskTypeId),
                    new SqlParameter("@ID2", sessionId),
                    new SqlParameter("@ID3", courseCategoryId),
                    new SqlParameter("@ID4", kioskId)
                };
                return await ExecuteStoredProcedureForListItemsAsync("up_SelectProgrammeListSessionWise", parameters);

            }
            catch (Exception ex)
            {
                throw;
            }
        }

        public async Task<List<ListItems>> GetCourseScheme(int courseSchemeId, int kioskTypeId, int kioskServiceId)
        {
            var parameters = new[]
            {
                    new SqlParameter("@ID1", courseSchemeId),
                    new SqlParameter("@ID2", kioskTypeId),
                    new SqlParameter("@ID3", kioskServiceId)
                };
            return await ExecuteStoredProcedureForListItemsAsync("up_SelectStudentCourseSchemeMaster", parameters);
        }
        public async Task<List<ListItems>> GetCourseScheme(int KioskTypeID, int ServiceID, int KioskID, int sessionid)
        {
            var parameters = new[]
            {
                    new SqlParameter("@ID1", null),
                    new SqlParameter("@ID2", KioskTypeID),
                    new SqlParameter("@ID3", ServiceID),
                    new SqlParameter("@ID4", KioskID),
                    new SqlParameter("@ID5", sessionid)
                };
            return await ExecuteStoredProcedureForListItemsAsync("up_SelectStudentCourseCategoryByKiosk2", parameters);
        }
        public async Task<List<ListItems>> GetCourseyear(int SessionID, int ProgrammeID, int SchemeID, int KIOSKID)
        {
            var parameters = new[]
            {
                    new SqlParameter("@ID1", SessionID),
                    new SqlParameter("@ID2", ProgrammeID),
                    new SqlParameter("@ID3", SchemeID),
                    new SqlParameter("@ID4", KIOSKID)
                };
            return await ExecuteStoredProcedureForListItemsAsync("up_SelectStudentCourseList", parameters);
        }
        public async Task<List<ListItems>> listRegistrationFeeHeads(int? courseFeeID, int? kioskID, int? sessionID, int? studentID)
        {
            var parameters = new[]
            {
                    new SqlParameter("@CourseFeeID", courseFeeID ),
                    new SqlParameter("@SessionID", sessionID),
                    new SqlParameter("@StudentID", studentID ?? (object)DBNull.Value),
                    new SqlParameter("@KioskID", kioskID)
                };
            return await ExecuteStoredProcedureForListItemsAsync("up_GetStudentRegistrationFee", parameters);
        }
        public async Task<List<ListItems>> GetServices(int KioskID, int kioskTypeId)
        {
            var parameters = new[]
            {
        new SqlParameter("@ID1", KioskID ),
        new SqlParameter("@ID2", kioskTypeId)

    };

            var data = await ExecuteStoredProcedureForListItemsAsync("up_SelectKIOSKTypeMasterByKioskID", parameters);
            return data;
        }

        public async Task<List<ListItems>> GetUniversity(int KioskID, int kioskTypeId)
        {
            var parameters = new[]
            {
        new SqlParameter("@ID1", kioskTypeId),
        new SqlParameter("@ID2", KioskID)

    };

            var data = await ExecuteStoredProcedureForListItemsAsync("up_SelectKIOSKServiceMasterByKiosk", parameters);
            return data;
        }
        public async Task<List<Listoptionalsubjects>> GetOptionalSubject(int courseFeeId, int mediumId)
        {
            try
            {
                var result = await _context.Database
            .SqlQuery<Listoptionalsubjects>($@"
                EXEC up_GetOptionalSubjectlist 
                    @coursefeeid = {courseFeeId}, 
                    @MediumID = {mediumId}, 
                    @CPMMappingID = NULL")
            .ToListAsync();

                return result;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public async Task<List<FeesList>> GetFeesAsync(int courseFeeId, int kioskId, int sessionId, int studentId)
        {
            try
            {
                var result = await _context.Database
                    .SqlQuery<FeesList>($@"
                EXEC dbo.up_GetStudentRegistrationFee 
                    @CourseFeeID = {courseFeeId}, 
                    @KIOSKID = {kioskId}, 
                    @SessionID = {sessionId}, 
                    @StudentID = {studentId}
            ")
                    .ToListAsync();

                return result ?? new List<FeesList>();
            }
            catch (Exception ex)
            {
                throw new Exception("Error executing stored procedure.", ex);
            }
        }
        public async Task<List<ListItems>> GetMasterList()
        {

            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>($@"EXEC up_SelectMasterListType").ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }
        public async Task<List<ListItems>> GetMasterData(int Id)
        {

            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>($@"
                EXEC up_SelectMasterList @ID={Id}
            ")
                   .ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }

        public async Task<int> UpdateAndCreateMasterData(int masterListTypeId, ListItems dto, int createdBy, string parentRoleName)
        {
            try
            {
                if (masterListTypeId == 51 && !string.IsNullOrEmpty(dto.TextField))
                {
                    dto.TextField = dto.TextField.Replace(" ", "");
                }
                var paramList = new List<SqlParameter>();

                // OUTPUT parameter
                var masterListIdParam = new SqlParameter("@MasterListID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.InputOutput,
                    Value = dto.ValueField // if 0 then It will create new row
                };
                paramList.Add(masterListIdParam);

                // INPUT parameters
                paramList.Add(new SqlParameter("@MasterListTypeID", SqlDbType.Int) { Value = masterListTypeId });
                paramList.Add(new SqlParameter("@MasterValue", SqlDbType.NVarChar, 200) { Value = dto.TextField ?? (object)DBNull.Value });
                paramList.Add(new SqlParameter("@CreatedBy", SqlDbType.Int) { Value = createdBy });
                paramList.Add(new SqlParameter("@ParentRoleName", SqlDbType.NVarChar, 100) { Value = parentRoleName ?? (object)DBNull.Value });
                string sql = @"
EXEC dbo.up_UpdateMasterList 
    @MasterListTypeID = @MasterListTypeID,
    @MasterListID = @MasterListID OUTPUT,
    @MasterValue = @MasterValue,
    @CreatedBy = @CreatedBy,
    @ParentRoleName = @ParentRoleName;
";

                var ID = await _context.Database.ExecuteSqlRawAsync(sql, paramList.ToArray());

                return ID;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public async Task<int> DaleteMasterData(int masterListTypeId, int masterListId)
        {
            try
            {
                var paramList = new List<SqlParameter>();
                // INPUT parameters
                paramList.Add(new SqlParameter("@MasterListTypeID", SqlDbType.Int) { Value = masterListTypeId });
                paramList.Add(new SqlParameter("@MasterListID", SqlDbType.NVarChar, 200) { Value = masterListId });

                string sql = @"
EXEC up_DeleteMasterList 
    @MasterListTypeID = @MasterListTypeID,
    @MasterListID = @MasterListID ;
";

                var ID = await _context.Database.ExecuteSqlRawAsync(sql, paramList.ToArray());

                return ID;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public async Task<List<ListItems>> GetKioskServiceList()
        {

            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>($@"
                EXEC up_SelectKIOSKTypeMaster @ID={null}
            ")
                   .ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }
        public async Task<List<ListItems>> KioskServiceListData(int Id)
        {

            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>($@"
                EXEC up_SelectMasterList @ID={Id}
            ")
                   .ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }

        public async Task<List<KioskServicesListDto>> GetKioskServiceData(int kioskTypeId)
        {
            try
            {
                var result = await _context.Database
                    .SqlQuery<KioskServicesListDto>($@"
                EXEC up_SelectKIOSKServicesList @KIOSKTypeID={kioskTypeId}, @KIOSKServiceID=NULL
            ")
                    .ToListAsync();

                return result ?? new List<KioskServicesListDto>();
            }
            catch (Exception ex)
            {
                // Optional: log the exception here
                throw ex;
            }
        }
        public async Task<int> InsertOrUpdateKioskService(KioskServicesListDto dto, int ServiceId)
        {
            try
            {
                var paramList = new List<SqlParameter>();
                var serviceIdParam = new SqlParameter("@ServiceID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.InputOutput,
                    Value = ServiceId
                };
                paramList.Add(serviceIdParam);
                if (ServiceId == 0) // INSERT
                {
                    paramList.Add(new SqlParameter("@CreatedOn", SqlDbType.DateTime) { Value = dto.CreatedOn ?? DateTime.Now });
                    paramList.Add(new SqlParameter("@CreatedBy", SqlDbType.Int) { Value = (object?)dto.CreatedBy ?? DBNull.Value });
                    paramList.Add(new SqlParameter("@UpdatedOn", SqlDbType.DateTime) { Value = DBNull.Value });
                    paramList.Add(new SqlParameter("@UpdatedBy", SqlDbType.Int) { Value = DBNull.Value });
                }
                else // UPDATE
                {
                    paramList.Add(new SqlParameter("@CreatedOn", SqlDbType.DateTime) { Value = DBNull.Value });
                    paramList.Add(new SqlParameter("@CreatedBy", SqlDbType.Int) { Value = DBNull.Value });
                    paramList.Add(new SqlParameter("@UpdatedOn", SqlDbType.DateTime) { Value = dto.UpdatedOn ?? DateTime.Now });
                    paramList.Add(new SqlParameter("@UpdatedBy", SqlDbType.Int) { Value = (object?)dto.UpdatedBy ?? DBNull.Value });
                }


                paramList.Add(new SqlParameter("@ServiceName", SqlDbType.VarChar, 250) { Value = dto.ServiceName ?? (object)DBNull.Value });
                paramList.Add(new SqlParameter("@KIOSKTypeID", SqlDbType.Int) { Value = dto.KIOSKTypeID });
                paramList.Add(new SqlParameter("@Imagepath", SqlDbType.VarChar, 1000) { Value = dto.ImagePath ?? (object)DBNull.Value });
                paramList.Add(new SqlParameter("@isActive", SqlDbType.Int) { Value = (dto.IsActive ?? false) ? 1 : 0 });
                paramList.Add(new SqlParameter("@IsFinancialService", SqlDbType.Bit) { Value = dto.IsFinancialService });

                string sql = @"
    EXEC up_InsertUpdateKIOSKServiceMaster
        @ServiceID = @ServiceID OUTPUT,
        @ServiceName = @ServiceName,
        @KIOSKTypeID = @KIOSKTypeID,
        @Imagepath = @Imagepath,
        @isActive = @isActive,
        @CreatedOn = @CreatedOn,
        @CreatedBy = @CreatedBy,
        @UpdatedOn = @UpdatedOn,
        @UpdatedBy = @UpdatedBy,
        @IsFinancialService = @IsFinancialService;
    ";

                // Execute the stored procedure
                await _context.Database.ExecuteSqlRawAsync(sql, paramList.ToArray());
                return (int)serviceIdParam.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        public async Task<List<MasterListDto>> GetMasterTypeList(int Id)
        {
            try
            {
                var result = await _context.Database
                   .SqlQuery<MasterListDto>($"EXEC up_SelectMasterList {Id}")
                   .ToListAsync();

                return result ?? new List<MasterListDto>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }

        [HttpPost]
        public async Task<MasterListDto> AddMasterItemAsync(MasterListDto item)
        {
            var entity = new KiosktypeMaster
            {
                KiosktypeId = item.ValueField,
                TypeName = item.TextField
            };
            _context.KiosktypeMasters.Add(entity);
            await _context.SaveChangesAsync();
            return item;
        }


        public async Task<KiosktypeMaster?> UpdateMasterItemAsync(int id, MasterListDto updatedItem)
        {
            var existing = await _context.KiosktypeMasters.FirstOrDefaultAsync(x => x.KiosktypeId == id);
            if (existing == null) return null;
            existing.TypeName = updatedItem.TextField;
            await _context.SaveChangesAsync();
            return existing;
        }


        public async Task<bool> DeleteMasterItemAsync(int id)
        {
            var entity = await _context.KiosktypeMasters.FirstOrDefaultAsync(x => x.KiosktypeId == id);
            if (entity == null) return false;
            _context.KiosktypeMasters.Remove(entity);   // ✅ fix here
            await _context.SaveChangesAsync();
            return true;
        }

        public async Task<List<SessionMaster>> GetSessionCourseList(int? sessionID, string role)
        {
            try
            {
                var sessionParam = new SqlParameter("sessionID", sessionID ?? (object)DBNull.Value);
                var roleParam = new SqlParameter("role", role ?? (object)DBNull.Value);

                var result = await _context.Database.SqlQueryRaw<SessionMaster>($"EXEC up_SelectSessionList @sessionID, @role", sessionParam, roleParam)
                   .ToListAsync();
                return result ?? new List<SessionMaster>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<CourseSubjectsOpt>> CourseSubjectsOpt()
        {
            try
            {
                var result = await _context.Database
                   .SqlQuery<CourseSubjectsOpt>($"EXEC up_GetCPMMappingMasterList_Two")
                   .ToListAsync();

                return result ?? new List<CourseSubjectsOpt>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<int> UpdateCourseOptionalSub(int cpmMappingId, int? noOfOptionalSub)
        {
            try
            {
                var result = await _context.Database.ExecuteSqlRawAsync(
                    "EXEC up_UpdateNoOfOptionalSubCPM @CPMMappingID, @NoOfOptionalSub",
                    new SqlParameter("@CPMMappingID", cpmMappingId),
                    new SqlParameter("@NoOfOptionalSub", noOfOptionalSub)
                );

                return result; // returns number of rows affected
            }
            catch (Exception ex)
            {
                // log error if needed
                throw; // rethrow so controller can handle
            }
        }
        public async Task<List<ListItems>> GetAccademyList()
        {

            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>($@"
                EXEC up_SelectCourseCategory 
            ")
                   .ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }
        public async Task<List<ListItems>> GetProgrammeListByCCID(int Id)
        {

            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>($@"
                EXEC sp_GetProgrammeListByCCID @AcademyID={Id}
            ")
                   .ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }
        public async Task<int> AcademyAllotment(int CourseCategoryId, string ProgrammeIds, int userId)
        {

            try
            {
                var result = await _context.Database.ExecuteSqlRawAsync(
             "EXEC up_ChangeAcedemyProgrammeWise @ProgrammeIds, @CourseCategoryId, @UserID",
             new SqlParameter("@ProgrammeIds", ProgrammeIds ?? (object)DBNull.Value),
             new SqlParameter("@CourseCategoryId", CourseCategoryId),
             new SqlParameter("@UserID", userId)
         );

                return result;
            }
            catch (Exception EX)
            {
                throw;
            }
        }

        public async Task<List<SessionMasterDtos>> GetSessionCourseListAsync(int? sessionID, string role)
        {
            try
            {
                var sessionParam = new SqlParameter("SessionID", sessionID ?? (object)DBNull.Value);
                var roleParam = new SqlParameter("RoleName", role ?? (object)DBNull.Value);

                return await _context.Database
                    .SqlQueryRaw<SessionMasterDtos>("EXEC up_SelectSessionList @SessionID, @RoleName", sessionParam, roleParam)
                    .ToListAsync() ?? new List<SessionMasterDtos>();
            }
            catch (Exception ex)
            {
                // Log exception here
                throw;
            }
        }

        public async Task<List<LateFeeMaster>> GetListLateFee(int? lateFeeID, int? sessionID)
        {
            try
            {
                var sessionParam = new SqlParameter("@LateFeeID", lateFeeID ?? (object)DBNull.Value);
                var roleParam = new SqlParameter("@SessionID", sessionID ?? (object)DBNull.Value);

                return await _context.Database
                    .SqlQueryRaw<LateFeeMaster>("EXEC up_SelectLateFeeListBySessionID @LateFeeID, @SessionID", sessionParam, roleParam)
                    .ToListAsync() ?? new List<LateFeeMaster>();
            }
            catch (Exception ex)
            {
                // Log exception here
                throw;
            }
        }
        public async Task<List<ListItems>> GetSessionList(int Id)
        {
            try
            {
                var result = await _context.Database.SqlQuery<ListItems>($@"EXEC 
@ID={Id}").ToListAsync();
                return result ?? new List<ListItems>();
            }
            catch (Exception ex)
            {
                // Optional: log the exception here
                throw ex;
            }
        }
        public async Task<List<ProgrammeDto>> GetProgrammeListAsync()
        {
            try
            {
                return await _context.Database
                    .SqlQueryRaw<ProgrammeDto>("EXEC up_SelectProgrammeMasterNew")
                    .ToListAsync() ?? new List<ProgrammeDto>();
            }
            catch (Exception ex)
            {
                // Log exception here
                throw;
            }
        }
        public async Task<List<CourseDto>> GetCourseListAsync(int programmeId)
        {
            var programmeParam = new SqlParameter("CourseID", programmeId);
            var nullParam = new SqlParameter("SessionID", DBNull.Value);

            return await _context.Database
                .SqlQueryRaw<CourseDto>("EXEC up_SelectCourseMaster @CourseID, @SessionID", programmeParam, nullParam)
                .ToListAsync();
        }

        public async Task<List<CourseFeeDto>> GetCourseFeeListAsync(int courseId, int? sessionId)
        {
            var courseParam = new SqlParameter("CourseID", courseId);
            var sessionParam = new SqlParameter("SessionID", sessionId ?? (object)DBNull.Value);

            return await _context.Database
                .SqlQueryRaw<CourseFeeDto>("EXEC up_SelectCourseFee @CourseID, @SessionID", courseParam, sessionParam)
                .ToListAsync();
        }


        public async Task<List<CourseFeeTypeDto>> GetCourseFeeTypeListAsync(int courseFeeId)
        {
            var param = new SqlParameter("CourseFeeID", courseFeeId);

            return await _context.Database
                .SqlQueryRaw<CourseFeeTypeDto>("EXEC up_SelectCourseFeeType @CourseFeeID", param)
                .ToListAsync();
        }


        public async Task<List<Dictionary<string, object>>> GetFeeTypeDetailListAsync(int courseFeeId)
        {
            var result = new List<Dictionary<string, object>>();

            using (var command = _context.Database.GetDbConnection().CreateCommand())
            {
                command.CommandText = "up_SelectCourseFeeTypeDetail";
                command.CommandType = CommandType.StoredProcedure;

                var param = command.CreateParameter();
                param.ParameterName = "@CourseFeeID";
                param.Value = courseFeeId;
                command.Parameters.Add(param);

                await _context.Database.OpenConnectionAsync();

                using (var reader = await command.ExecuteReaderAsync())
                {
                    while (await reader.ReadAsync())
                    {
                        var row = new Dictionary<string, object>();

                        for (int i = 0; i < reader.FieldCount; i++)
                        {
                            row[reader.GetName(i)] = reader.IsDBNull(i) ? null : reader.GetValue(i);
                        }

                        result.Add(row);
                    }
                }
            }

            return result;
        }
        public async Task<List<LookupDto>> GetCourseCategoriesAsync()
    => await _context.Database.SqlQueryRaw<LookupDto>("EXEC up_SelectCourseCategory").ToListAsync();

        public async Task<List<LookupDto>> GetDepartmentsAsync()
            => await _context.Database.SqlQueryRaw<LookupDto>("EXEC up_selectdepartment").ToListAsync();

        public async Task<List<LookupDto>> GetSkillsAsync()
            => await _context.Database.SqlQueryRaw<LookupDto>("EXEC usp_getNSDC").ToListAsync();
        public async Task<List<LookupDto>> GetStudyMaterialOptionsAsync()
            => await _context.Database.SqlQueryRaw<LookupDto>("EXEC usp_getStudyMaterialYN").ToListAsync();

        public async Task<int> SaveProgrammeAsync(ProgrammeDto dto)
        {
            try
            {

                var pId = new SqlParameter("@ProgrammeID", dto.ProgrammeID ?? 0)
                {
                    Direction = ParameterDirection.InputOutput
                };

                // Map Skill (string -> int)
                int skillValue = 0;
                if (dto.Skill?.ToUpper() == "NSDC") skillValue = 1;
                else if (dto.Skill?.ToUpper() == "NON-NSDC") skillValue = 2;

                // Map StudyMaterialYN (bool? -> bit)
                //int studyMaterialValue = (dto.StudyMaterialYN.HasValue && dto.StudyMaterialYN.Value) ? 1 : 0;
                int studyMaterialValue = (dto.StudyMaterialYN.HasValue && dto.StudyMaterialYN.Value) ? 1 : 0;

                // Remove the mapping to int
                var parameters = new[]
                {
    pId,
    new SqlParameter("@ProgrammeName", SqlDbType.NVarChar, 200) {
    Value = (object)dto.ProgrammeName ?? DBNull.Value
},
    new SqlParameter("@NoOfCourse", dto.NoOfCourse),
    new SqlParameter("@KIOSKTypeID", 1),
    new SqlParameter("@KIOSKServiceID", 1),
    new SqlParameter("@CreatedBy", 1),
    new SqlParameter("@UpdatedBy", 1),
    new SqlParameter("@IsActive", 1),
    new SqlParameter("@CourseCategoryID", dto.CourseCategoryID),
    new SqlParameter("@DeptId", (object?)dto.DeptId ?? DBNull.Value),
    // ✅ send string as-is
    new SqlParameter("@Skill", SqlDbType.NVarChar, 200) {
    Value = (object)dto.Skill ?? DBNull.Value
},
new SqlParameter("@Eligibillity", SqlDbType.NVarChar, 100) {
    Value = (object)dto.Eligibillity ?? DBNull.Value
},
new SqlParameter("@Remarks", SqlDbType.NVarChar, 1000) {
    Value = (object)dto.Remarks ?? DBNull.Value
},
    new SqlParameter("@StudyMaterialYN", dto.StudyMaterialYN ?? (object)DBNull.Value)
};


                await _context.Database.ExecuteSqlRawAsync(
                    "EXEC up_SaveProgrammeMaster @ProgrammeID OUTPUT, @ProgrammeName, @KIOSKTypeID, @KIOSKServiceID, @NoOfCourse, @CreatedBy, @UpdatedBy, @IsActive, @CourseCategoryID, @DeptId, @Skill, @Eligibillity, @Remarks, @StudyMaterialYN",
                    parameters
                );

                return (int)pId.Value;
            }
            catch (Exception ex)
            {
                throw ex;
            }

        }
        public async Task<List<ProgrammeListItems>> GetAllKiosk()
        {
            try
            {
                return await _context.Database
                               .SqlQuery<ProgrammeListItems>($"EXEC up_SelectKioskBranchCodeListAll1")
                               .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }
        }


        public async Task<List<ListItems>> GetServiceByKiosk(int id)
        { try
            {
                return await _context.Database
                    .SqlQueryRaw<ListItems>("EXEC up_SelectKIOSKServiceMasterByKiosk @ID1, @ID2",
                     new SqlParameter("@ID1", 1)
                     , new SqlParameter("@ID2", id))
                    .ToListAsync() ?? new List<ListItems>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<ListItems>> GetCourseCtgByserviceID(int service, int kioskId)
        {
            try

            {
                return await _context.Database
                    .SqlQueryRaw<ListItems>("EXEC up_SelectCourseCategoryByKioskService @ID1, @ID2,@ID3",
                    new SqlParameter("@ID1", kioskId),
                    new SqlParameter("@ID2", 1),
                    new SqlParameter("@ID3", service))

                    .ToListAsync() ?? new List<ListItems>();
            }
            catch (Exception ex)
            {
                throw;
            }
        }
        public async Task<List<ListItems>> GetCheckBoxForProgramAllotment(int? KioskId, int? serviceId, int IsAlloted, int? courseCategoryId, int? programId)
        {
            try
            {
                var result = await _context.Database
                    .SqlQueryRaw<ListItems>(
                        "EXEC up_GetProgrammeAssigned @KIOSKID, @KIOSKServiceID, @ProgrammeID, @IsAssigned,@CourseCategoryID",
                       new SqlParameter("@KIOSKID", KioskId ?? (object)DBNull.Value),
                       new SqlParameter("@KIOSKServiceID", serviceId ?? (object)DBNull.Value),
                        new SqlParameter("@ProgrammeID", programId ?? (object)DBNull.Value),
                        new SqlParameter("@IsAssigned", IsAlloted),
                        new SqlParameter("@CourseCategoryID", courseCategoryId ?? (object)DBNull.Value)
                    )
                    .ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }

        }
        public async Task<int> ProgramAllotmentPost(string KioskIds, string ProgrammeIds, int KIOSKServiceId, int UserID, int CourseCategoryID)
        {
            try
            {
                var parameters = new[]
 {
    new SqlParameter("@KIOSKId", SqlDbType.NVarChar, 4000) { Value = KioskIds },
    new SqlParameter("@ProgrammeId", SqlDbType.NVarChar, 4000) { Value = ProgrammeIds },
    new SqlParameter("@KIOSKServiceId", SqlDbType.NVarChar, 2000) { Value =(KIOSKServiceId == 0) ? DBNull.Value : (object)KIOSKServiceId},
    new SqlParameter("@UserID", SqlDbType.Int) { Value = 5609 },
    new SqlParameter("@CourseCategoryID", SqlDbType.Int) { Value = (CourseCategoryID == 0) ? DBNull.Value : (object)CourseCategoryID   }
};

                var result = await _context.Database.ExecuteSqlRawAsync(
                     "EXEC up_InsertKIOSKProgramme_2 @KIOSKId, @ProgrammeId, @KIOSKServiceId, @UserID, @CourseCategoryID",
                     parameters);

                //     var result = await _context.Database.ExecuteSqlRawAsync(
                //"EXEC up_InsertKIOSKProgramme @KIOSKId, @ProgrammeIds, @KIOSKServiceId,@UserID,@CourseCategoryID",
                //new SqlParameter("@KIOSKId", KioskIds),
                //new SqlParameter("@ProgrammeIds", ProgrammeIds),
                //new SqlParameter("@KIOSKServiceId", KIOSKServiceId),
                //new SqlParameter("@UserID", UserID),
                //new SqlParameter("@CourseCategoryID", CourseCategoryID));
                return result;
            }
            catch (Exception ex)
            {
                throw;
            }
        }



        public SessionMasterDtos UpdateSession(SessionMasterDtos model)
        {
            var session = _context.SessionMasters.FirstOrDefault(x => x.SessionId == model.SessionID);
            if (session == null)
                throw new Exception("Session not found");

            // Map fields
            session.KioskTypeId = model.KioskTypeID;
            session.KioskServiceId = model.KioskServiceID;
            session.SessionMasterListId = model.SessionMasterListID;
            session.SessionStartDate = model.SessionStartDate;
            session.SessionEndDate = model.SessionEndDate;
            session.Status = model.Status;
            _context.SaveChanges();
            return model; // return updated DTO
        }

        public int AddLateFeeMaster(LateFeeMaster entity)
        {
            try
            {
                var LateFeeIdParam = new SqlParameter("@LateFeeId", SqlDbType.Int)
                {
                    Direction = ParameterDirection.InputOutput,
                    Value = entity.LateFeeId
                };
                var SessionIDParam = new SqlParameter("@SessionID", entity.SessionId);
                var DaysParam = new SqlParameter("@Days", entity.Days);
                var LateFeeAmountParam = new SqlParameter("@LateFeeAmount", entity.LateFeeAmount);
                var IsActiveParam = new SqlParameter("@IsActive", entity.IsActive);
                _context.Database.ExecuteSqlRaw(
                "EXEC up_SaveLateFeeMaster @LateFeeId OUT, @SessionID, @Days, @LateFeeAmount,@IsActive",
                LateFeeIdParam, SessionIDParam, DaysParam, LateFeeAmountParam, IsActiveParam);
                return Convert.ToInt32(LateFeeIdParam.Value);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public LateFeeMaster UpdateLateFeeMaster(LateFeeMaster model)
        {
            // Define SQL parameters
            var lateFeeIdParam = new SqlParameter
            {
                ParameterName = "@LateFeeId",
                SqlDbType = SqlDbType.Int,
                Direction = ParameterDirection.InputOutput,
                Value = model.LateFeeId == 0 ? DBNull.Value : model.LateFeeId
            };

            var sessionIdParam = new SqlParameter("@SessionID", model.SessionId);
            var daysParam = new SqlParameter("@Days", model.Days);
            var lateFeeAmountParam = new SqlParameter("@LateFeeAmount", model.LateFeeAmount);
            var isActiveParam = new SqlParameter("@IsActive", model.IsActive);

            // Execute stored procedure
            _context.Database.ExecuteSqlRaw(
                "EXEC up_SaveLateFeeMaster @LateFeeId OUT, @SessionID, @Days, @LateFeeAmount, @IsActive",
                lateFeeIdParam, sessionIdParam, daysParam, lateFeeAmountParam, isActiveParam);

            // Get the output value (new LateFeeId from SP)
            model.LateFeeId = (int)lateFeeIdParam.Value;

            return model; // return the updated entity
        }

        public LateFeeMaster GetLateFeeMasterById(int lateFeeId)
        {

            return _context.LateFeeMasters.FirstOrDefault(l => l.LateFeeId == lateFeeId);
        }

        public int InsertUpdateCourseSession(SessionMasterDtos session)
        {
            try
            {
                var sessionIdParam = new SqlParameter("@SessionID", SqlDbType.Int)
                {
                    Direction = ParameterDirection.InputOutput,
                    Value = session.SessionID // if 0 then It will create new row
                };

                var masterListIdParam = new SqlParameter("@SessionMasterListID", session.SessionMasterListID);
                var startDateParam = new SqlParameter("@SessionStartDate", session.SessionStartDate);
                var endDateParam = new SqlParameter("@SessionEndDate", session.SessionEndDate);
                var createdByParam = new SqlParameter("@CreatedBy", 1);
                var kioskTypeIdParam = new SqlParameter("@KioskTypeID", session.KioskTypeID);
                var kioskServiceIdParam = new SqlParameter("@KioskServiceID", session.KioskServiceID);
                var statusIdParam = new SqlParameter("@Status", session.Status);

                _context.Database.ExecuteSqlRaw(
                "EXEC up_InsertUpdateSessionMaster @SessionID OUT, @SessionMasterListID, @SessionStartDate, @SessionEndDate,@CreatedBy, @KioskTypeID, @KioskServiceID,@Status",
                sessionIdParam, masterListIdParam, startDateParam, endDateParam, createdByParam, kioskTypeIdParam, kioskServiceIdParam, statusIdParam);

                return (int)sessionIdParam.Value;
                // return Convert.ToInt32(sessionIdParam.Value);
            }
            catch (Exception)
            {
                return 0;
            }
        }
        public async Task<List<ListItems>> GetAllPrograms()
        {
            try
            {
                return await _context.Database
                              .SqlQuery<ListItems>($"EXEC up_SelectProgrammeListWithCourseCate")
                              .ToListAsync();
            }
            catch (Exception ex)
            {
                throw;
            }

        }
        public async Task<List<ListItems>> GetSessions()
        {

            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>($@"EXEC up_SelectAllSessionMasterSearch").ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }
        public async Task<List<ListItems>> GetStatus()
        {
            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>($@"EXEC up_SelectMasterList @ID={31}").ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }
        public async Task<List<ListItems>> GetKiosks()
        {

            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>($@"EXEC up_SelectKioskBranchCodeListAll").ToListAsync();

                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }
        public async Task<List<ListItems>> GetCoursesByCentreCodeID(int? id,int KioskId)
        {
            try
            {
                var result = await _context.Database
                   .SqlQuery<ListItems>(
                  $"EXEC up_SelectCoursesListNew @ID1={id}, @ID2={KioskId}"
                  ).ToListAsync();
                return result ?? new List<ListItems>();
            }
            catch (Exception EX)
            {
                throw;
            }
        }

        public async Task<List<RolesMenuMaster>> GetAllMenuTest(int Userid)
        {
            try
            {
                // Method 1: Formatted SQL with parameter (SAFEST - prevents SQL injection)
                var userIdParam = new Microsoft.Data.SqlClient.SqlParameter("@UserId", Userid);
                var data = await _context.RolesMenuMasters
                    .FromSqlRaw("EXEC Get_All_MenuMaster @UserId", userIdParam)
                    .ToListAsync();

                return data;
            }
            catch (Exception ex)
            {
                throw;
            }
        }

    }
}
