using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.Students;
namespace AisectOnline.Services.Modules.MasterData
{
    public interface IMasterDataService
    {
        Task<List<MasterList>> GetMasterDataAsync(int id);
        Task<List<StateMaster>> GetAllStatesAsync();
        Task<List<DistrictMaster>> GetDistrictByIDAsync(int StID);
        Task<List<ListItems>> GetSessionRaw(int? sessionId, int KioskTypeId, int KioskServiceID, int UserID);
        Task<List<ListItems>> GetCourseCategory(int KioskTypeId, int KioskServiceID, int KioskID);
        Task<List<ListItems>> GetProgrammes(int KioskTypeID, int SessionId, int CourseCategoryID, int KioskID);
        Task<List<ListItems>> GetCourseScheme(int courseSchemeId, int kioskTypeId, int kioskServiceId);
        Task<List<ListItems>> GetCourseyear(int SessionID, int ProgrammeID, int SchemeID, int KIOSKID);
        Task<List<ListItems>> listRegistrationFeeHeads(int? courseFeeID, int? kioskID, int? sessionID, int? studentID);
        Task<List<ListItems>> GetServices(int KioskID, int kioskTypeId);
        Task<List<ListItems>> GetUniversity(int KioskID, int kioskTypeId);
        Task<List<Listoptionalsubjects>> GetOptionalSubject(int courseFeeId, int mediumId);
        Task<List<FeesList>> GetFeesAsync(int courseFeeId, int kioskId, int sessionId, int studentId);
        Task<List<ListItems>> GetMasterList();
        Task<List<ListItems>> GetMasterData(int Id);
        Task<int> UpdateAndCreateMasterData(int masterListTypeId,ListItems dto, int createdBy, string parentRoleName);
        Task<int> DaleteMasterData(int masterListTypeId, int masterListId);
        Task<List<ListItems>> GetKioskServiceList();
        Task<List<KioskServicesListDto>> GetKioskServiceData(int id);
        Task<List<ListItems>> GetSessionList(int Id);
        Task<List<MasterListDto>> GetMasterTypeList(int Id);
        Task<MasterListDto> AddMasterItemAsync(MasterListDto item);
        Task<KiosktypeMaster?> UpdateMasterItemAsync(int id, MasterListDto updatedItem);

        Task<bool> DeleteMasterItemAsync(int id);
        Task<int> InsertOrUpdateKioskService(  KioskServicesListDto dto, int ServiceId);

        Task<List<SessionMaster>> GetSessionCourseList(int? sessionID, string role);
        Task<List<CourseSubjectsOpt>> CourseSubjectsOpt();
        Task<int> UpdateCourseOptionalSub(int CPMMappingID,int? NoOfOptionalSub);
        Task<List<ListItems>> GetAccademyList();
        Task<List<ListItems>> GetProgrammeListByCCID(int Id);
        Task<int> AcademyAllotment(int CourseCategoryId, string ProgrammeIds, int userId);

        Task<List<SessionMasterDtos>> GetSessionCourseListAsync(int? sessionID, string role);
        Task<List<LateFeeMaster>> GetListLateFee(int? lateFeeID, int? sessionID);

        Task<List<ProgrammeListItems>> GetAllKiosk();
        Task<List<ListItems>> GetServiceByKiosk(int id);

        Task<List<ProgrammeDto>> GetProgrammeListAsync();
        Task<List<CourseDto>> GetCourseListAsync(int programmeId);
        Task<List<ListItems>> GetCourseCtgByserviceID(int service, int kioskId);
        Task<List<CourseFeeDto>> GetCourseFeeListAsync(int courseId, int? sessionId);
        Task<List<CourseFeeTypeDto>> GetCourseFeeTypeListAsync(int courseFeeId);
        Task<List<Dictionary<string, object>>> GetFeeTypeDetailListAsync(int courseFeeId);
        Task<List<LookupDto>> GetCourseCategoriesAsync();
        Task<List<LookupDto>> GetDepartmentsAsync();
        Task<List<LookupDto>> GetSkillsAsync();
        Task<List<LookupDto>> GetStudyMaterialOptionsAsync();
        Task<int> SaveProgrammeAsync(ProgrammeDto dto);
        Task<List<ListItems>> GetCheckBoxForProgramAllotment(int? KioskId, int? serviceId, int IsAlloted, int? courseCategoryId, int? programId);
        Task<int> ProgramAllotmentPost(string KioskIds, string ProgrammeIds, int KIOSKServiceId, int UserID,int CourseCategoryID);
        SessionMasterDtos UpdateSession(SessionMasterDtos model);
        int AddLateFeeMaster(LateFeeMaster entity);
        int InsertUpdateCourseSession(SessionMasterDtos session);
        LateFeeMaster UpdateLateFeeMaster(LateFeeMaster _LateFeeMaster);
        LateFeeMaster GetLateFeeMasterById(int lateFeeId);
        Task<List<ListItems>> GetAllPrograms();
        Task<List<ListItems>> GetSessions();
        Task<List<ListItems>> GetStatus();
        Task<List<ListItems>> GetKiosks();
        Task<List<ListItems>> GetCoursesByCentreCodeID(int? id, int KioskId);
        Task<List<RolesMenuMaster>> GetAllMenuTest(int Userid);
    }
}
