


using AisectOnline.Data.Models;
using AisectOnline.Services.Modules.Students;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using static AisectOnline.Services.Modules.Common.CommonDTO;


namespace AisectOnline.Services.Modules.MasterData
{

    public class MasterDataListDto
    {
        public List<ListItems> MasterDataTypeList { get; set; }
        public int MasterDataTypeList_Id { get; set; }
    }
    public class KioskServiceListDto
    {
        public List<ListItems> KioskServiceList { get; set; }
        public int KioskServiceList_Id { get; set; }
    }
    public class KioskServicesListDto
    {
        public int? KIOSKServiceID { get; set; }
        public string? ServiceName { get; set; }   // Nullable string
        public int? KIOSKTypeID { get; set; }      // Nullable int
        public string? ImagePath { get; set; }
        public bool? IsActive { get; set; }        // Nullable bool
        public DateTime? CreatedOn { get; set; }   // Nullable DateTime
        public int? CreatedBy { get; set; }
        public DateTime? UpdatedOn { get; set; }
        public int? UpdatedBy { get; set; }
        public int? IsFinancialService { get; set; } // Added this

    }

    public class MasterListDto
    {
        public int ValueField { get; set; }
        public string TextField { get; set; }
    }
    public class ProgrammeListItems
    {
        public int? ValueField { get; set; }       // KIOSKID
        public string? TextField { get; set; }      // KIOSKCode + " - " + KIOSKName
        public DateTime? UpdatedOn { get; set; }   // UpdatedOn can be null
        public int? UpdatedIn_3days { get; set; }  // 1 or 0, keep nullable for safety
    }

    public class ProgrammeAllotment
    {
        public List<ProgrammeListItems>? KioskList { get; set; }
        public List<ListItems>? Services { get; set; }
        public int ? ServicesId { get; set; }
        public int ? KioskId { get; set; }

    }

    public class CourseSubjectsOpt
    {
        public int   CPMMappingID { get; set; }
        public string? CourseCategory { get; set; }
        public string? ProgrammeName { get; set; }
        public string? CourseCode { get; set; }
        public string? CourseName { get; set; }
        public string? Medium { get; set; }
        public string? CPMMappingCode { get; set; }
        public int? NoOfOptionalsub { get; set; }

    }

    public class SessionMasterDtos
    {
        public int SessionID { get; set; }
        public int? SessionMasterListID { get; set; }
        public DateTime? SessionStartDate { get; set; }  // keep as DateTime
        public DateTime? SessionEndDate { get; set; }    // keep as DateTime
        public int? KioskTypeID { get; set; }
        public int? KioskServiceID { get; set; }
        public int? Status { get; set; }
        public int? ReviewBy { get; set; }
        public string? ReviewByName { get; set; }
        public string? ReviewDate { get; set; }   // string, varchar MM/dd/yyyy
        public int? AppRejByName { get; set; }
        public string? LoginID { get; set; }
        public string? AppRejDate { get; set; }   // string, varchar MM/dd/yyyy
        public int? SessionCourseFeeStatus { get; set; }
        public int IsOpen { get; set; }

        public string? session { get; set; }
        public string? ServiceName { get; set; }
        public string? TypeName { get; set; }
        public List<SessionMasterDtos> SessionMasterList { get; set; }

        [NotMapped]
        public List<ListItems> KioskTypeList { get; set; }
        [NotMapped]
        public List<LateFeeMaster> LateFeeMasterList { get; set; }
    }

    public class ProgrammeDto
    {
        public int? ProgrammeID { get; set; }
        public string? ProgrammeName { get; set; }
        public int? NoOfCourse { get; set; }
        public string? Skill { get; set; }      // NSDC / NON-NSDC
        public string? Eligibillity { get; set; }
        public string? Remarks { get; set; }
        public int? CourseCategoryID { get; set; }
        public string? Reviewed { get; set; }
        public string? DepartmentName { get; set; }
        public int? DeptId { get; set; }
        public string? CourseCategory { get; set; }
        public bool? StudyMaterialYN { get; set; }  // ✅ Bit in table
    }

    public class SessionDto
    {
        public int SessionID { get; set; }
        public int SessionMasterListID { get; set; }
        public DateTime? SessionStartDate { get; set; }
        public DateTime? SessionEndDate { get; set; }
        public int KioskTypeID { get; set; }
        public string? TypeName { get; set; }
        public int KioskServiceID { get; set; }
        public string? ServiceName { get; set; }
        public int? Status { get; set; }
        public int? SessionStatus { get; set; }

        [NotMapped]
        public IList<ProgrammeDto> listProgramme { get; set; } = new List<ProgrammeDto>();
    }

    public class CourseDto
    {
        public int? CourseID { get; set; }
        public string? Name { get; set; }
        public string? ShortName { get; set; }
        public int? Duration { get; set; }
        public int? CourseCategoryID { get; set; }
        public string? CourseCategory { get; set; }
        public string? CourseCode { get; set; }
    }

    public class CourseFeeDto
    {
        public int CourseFeeID { get; set; }
        public int CourseID { get; set; }
        public string Name { get; set; }
        public string ShortName { get; set; }
        public int Duration { get; set; }
        public string CourseFeeName { get; set; }
        public decimal Fee { get; set; }
        public int SchemeID { get; set; }
        public string CourseScheme { get; set; }
    }

    public class CourseFeeTypeDto
    {
        public int CourseFeeTypeID { get; set; }
        public int CourseFeeID { get; set; }
        public string CourseFeeName { get; set; }
        public int FeeTypeID { get; set; }
        public string FeeType { get; set; }
        public decimal Fee { get; set; }
        public int? PaymentModeID { get; set; }   // 👈 notice Id not ID
        public int? FeeTypeAdded { get; set; }
    }

    public class LookupDto
    {
        public int ValueField { get; set; }
        public string TextField { get; set; }
    }


    public class FeeTypeDetailDto
    {
        public int CourseFeeTypeID { get; set; }
        public int CourseFeeID { get; set; }
        public string CourseName { get; set; }
        public int Duration { get; set; }
        public string FeeTypeID { get; set; }
        public string FeeTypeName { get; set; }
        public int FeeTypeFee { get; set; }
        //public decimal HeadFee { get; set; }
        //public decimal MonthFee { get; set; }
    }

}
