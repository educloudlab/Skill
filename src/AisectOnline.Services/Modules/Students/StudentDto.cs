using AisectOnline.Data.Models;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AisectOnline.Services.Modules.Students
{
    public class StudentDto
    {
        public int StudentId { get; set; }

        public string RequestNo { get; set; } = null!;
        [Required(ErrorMessage = "First name is required.")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "First name must contain only Alphabet.")]
        public string FirstName { get; set; } = null!;
        [Required(ErrorMessage = "Last name is required.")]
        [RegularExpression("^[A-Za-z]+$", ErrorMessage = "Last name must contain only Alphabet.")]
        public string LastName { get; set; } = null!;
        [Required(ErrorMessage = "Father name is required.")]
        [RegularExpression(@"^[A-Za-z]+( [A-Za-z]+)?$", ErrorMessage = "Father Name name must contain only alphabets and only space between words.")]
        public string? FatherName { get; set; }

        [Required(ErrorMessage = "Mother name is required.")]
        [RegularExpression(@"^[A-Za-z]+( [A-Za-z]+)?$", ErrorMessage = "Mother Name name must contain only alphabets and only space between words.")]

        public string? MotherName { get; set; }

        public DateTime Dob { get; set; }

        public string? Telephone { get; set; }

        [Required(ErrorMessage = "ContactAddress name is required.")]
        public string ContactAddress { get; set; } = null!;
        [Required(ErrorMessage = "Pin name is required.")]
        public string? Pin { get; set; }
        [Required(ErrorMessage = "MobileNo name is required.")]
        public string MobileNo { get; set; } = null!;

        public string? FaxNo { get; set; }
        [Required(ErrorMessage = "VillageTownCity name is required.")]
        public string VillageTownCity { get; set; } = null!;

        [Required(ErrorMessage = "Email address is required.")]
        [EmailAddress(ErrorMessage = "Invalid email address format.")]
        public string EmailAddress { get; set; } = null!;


        public int IsPhysicallyHandicapped { get; set; }

        [Required(ErrorMessage = "Medium name is required.")]
        public int Medium { get; set; }
        //[Required(ErrorMessage = "OtherMedium name is required.")]
        public string? OtherMedium { get; set; }

        public string MainSubject { get; set; } = null!;
        [Required(ErrorMessage = "YearOfPassing name is required.")]
        public int YearOfPassing { get; set; }
        [Required(ErrorMessage = "Division name is required.")]
        public string Division { get; set; } = null!;
        [Required(ErrorMessage = "Marks percentage is required.")]
        [Range(33, 100, ErrorMessage = "Marks percentage must be between 33 and 100.")]
        public decimal MarksPercentage { get; set; }
        [Required(ErrorMessage = "BoardCode percentage is required.")]
        public string BoardCode { get; set; } = null!;

        public int Religion { get; set; }

        public int WhetherMinority { get; set; }

        public int SocialStatus { get; set; }

        public int WhetherKashmiriMigrant { get; set; }

        public int WhetherPersonWithDisability { get; set; }

        public int NatureDisability { get; set; }

        public string? OtherNatureDisability { get; set; }

        public int EmploymentStatus { get; set; }

        public decimal AnnualScholarshipAmount { get; set; }
        [Required(ErrorMessage = "Family Income Yearly is required.")]
        public decimal? FamilyIncomeYearly { get; set; }

        public int DeptOfferingScholarship { get; set; }

        public int BelowPovertyLine { get; set; }

        public int KioskTypeID { get; set; }

        public int ServiceId { get; set; }

        public int ProgrammeId { get; set; }

        public DateTime CreatedOn { get; set; }

        public int CreatedBy { get; set; }

        public DateTime? UpdatedOn { get; set; }

        public int? UpdatedBy { get; set; }

        public bool IsActive { get; set; }

        public int Status { get; set; }

        public int? GovtEmployee { get; set; }

        public int Kioskid { get; set; }

        public string BranchManager { get; set; }

        public bool? IsKiosk { get; set; }

        public string? AadharNo { get; set; }

        public string? DrivingLicenceNo { get; set; }

        public bool? IsHokiosk { get; set; }

        public string? CorresAddress { get; set; }

        public string? CorresPin { get; set; }

        public string? CorresVillageTownCity { get; set; }

        public string? CorresContactNo { get; set; }

        public string? UserId { get; set; }

        public string? Password { get; set; }

        public bool? LmsCsvSend { get; set; }

        public string? ProspectusNo { get; set; }

        public string? OfflineBranchcode { get; set; }

        public int? OldstudentId { get; set; }

        public string? OlddataBaseName { get; set; }

        public string? OldrequestNo { get; set; }

        public string? EnrollmentNo { get; set; }

        public int? Lscid { get; set; }

        public string? TallyRegistrationNo { get; set; }

        public string? Abc { get; set; }

        public string? Deb { get; set; }

        public string? DateOfJoining { get; set; }
        public string? profilephoto { get; set; }
        //selected  ID
        [Required(ErrorMessage = "Please select the session.")]
        public int? Session{ get; set; }
        [Required(ErrorMessage = "Please select the Faculty/Academy.")]
        public int? CourseCategory { get; set; }
        [Required(ErrorMessage = "Please select the University/Scheme.")]
        public int? Scheme { get; set; }
        [Required(ErrorMessage = "Please select the Course/Years.")]
        public int? CourseFeeID  { get; set; }
        [Required(ErrorMessage = "Please select the Preferd Course Medium.")]
        public int? CourseMedium1  { get; set; }
        [Required(ErrorMessage = "Please select the Program Name.")]
        public int? Program  { get; set; }
        public int? CorresDistrict  { get; set; }
        public int? CorresState  { get; set; }
        public int? CourseMedium  { get; set; }
        public int? DrivingLicenceType  { get; set; }
        public int? District  { get; set; }
        public int? State  { get; set; }
        public int? AcademicQualification  { get; set; }
        public int? Sex  { get; set; }
        public int? Category  { get; set; }
        public int? StudentBelongsTo  { get; set; }
        public int? Nationality  { get; set; }
        public int? MaritalStatus  { get; set; }
        //OTHER FIELDS
        [NotMapped]
        public List<ListItems>? SessionDropdown { get; set; }
        [NotMapped]
        public List<ListItems>? CourseCategoryDropdown { get; set; }
        [NotMapped]
        public List<ListItems>? SchemeDropdown { get; set; }
        [NotMapped]
        public List<ListItems>? CourseFeeIDDropdown { get; set; }
        [NotMapped]
        public List<ListItems>? CourseMedium1Dropdown { get; set; }
        [NotMapped]
        public List<ListItems>? ProgramDropdown { get; set; }
        [NotMapped]
        public List<District>? CorresDistrictDropdown { get; set; }
        [NotMapped]

        public List<ListItems>? CorresStateDropdown { get; set; }
        [NotMapped]

        public List<ListItems>? CourseMediumDropdown { get; set; }
        [NotMapped]
        public List<ListItems>? DrivingLicenceTypeDropdown { get; set; }
        [NotMapped]
        public List<DistrictMaster>? DistrictDropdown { get; set; }
        [NotMapped]

        public List<ListItems>? StateDropdown { get; set; }
        [NotMapped]

        public List<ListItems>? AcademicQualificationDropdown { get; set; }
        [NotMapped]

        public List<ListItems>? SexDropdown { get; set; }
        [NotMapped]

        public List<ListItems>? CategoryDropdown { get; set; }
        [NotMapped]

        public List<ListItems>? StudentBelongsToDropdown { get; set; }
        [NotMapped]


        public List<ListItems>? NationalityDropdown { get; set; }
        [NotMapped]

        public List<ListItems>? MaritalStatusDropdown { get; set; }
  
    }
    //For Items Lists
    public class FeesList
    {
        public string FeeType { get; set; }
        public decimal? Fee { get; set; } 
        public string ?PayBefore { get; set; }
    }
    public class ListItems
    {
        public int ValueField { get; set; }
        public string? TextField { get; set; }
    }
    public class Listoptionalsubjects
    {
        public string ValueField { get; set; }
        public string TextField { get; set; }
    }
    public class StudentRegistration1 {
        public int kioskID { get; set; }
        public int kioskTypeID { get; set; }
        public List<ListItems>? Services {get;set;}
        public List<ListItems>? Univercity {get;set;}
        public int  Services_Id { get; set; }
        public int Univercity_Id { get; set; }
        public string captcha { get; set; }

    }
    public class StudentInsertReturn
    {
        public int studentID { get; set; }
        public string RequestNo { get; set; }
     

    }
    public class StudentPrintDto
    {
        public int StudentId { get; set; }
        public string RequestNo { get; set; }
        public string? Session { get; set; }
        public string CourseCategory { get; set; }
        public string ProgrammeName { get; set; }
        public string ServiceName { get; set; }
        public string CourseMedium { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public DateTime Dob { get; set; }
        public string? Telephone { get; set; }
        public string? ContactAddress { get; set; }
        public string? Pin { get; set; }
        public string? MobileNo { get; set; }
        public string? FaxNo { get; set; }
        public string? VillageTownCity { get; set; }
        public string? District { get; set; }   // <- now string
        public string? State { get; set; }      // <- now string
        public string? EmailAddress { get; set; }
        public string? AcademicQualification { get; set; } // <- string
        public string? Sex { get; set; }
        public string? Category { get; set; }
        public string? Medium { get; set; }
        public string? MainSubject { get; set; }
        public int?   YearOfPassing { get; set; }
        public string? Division { get; set; }
        public decimal? MarksPercentage { get; set; }
        public string? BoardCode { get; set; }
        public string? Nationality { get; set; }
        public string? MaritalStatus { get; set; }
        public string? Religion { get; set; }
        public string? WhetherMinority { get; set; }
        public string? SocialStatus { get; set; }
        public string? WhetherKashmiriMigrant { get; set; }
        public string? WhetherPersonWithDisability { get; set; }
        public string? NatureDisability { get; set; }
        public string? EmploymentStatus { get; set; }
        public decimal? AnnualScholarshipAmount { get; set; }
        public decimal? FamilyIncomeYearly { get; set; }
        public string? DeptOfferingScholarship { get; set; }
        public string? BelowPovertyLine { get; set; }
        public string? GovtEmployee { get; set; }
        public string? Course { get; set; }
        public string? CourseScheme { get; set; }
        public string? LicenceTypeName { get; set; }
        public string? AadharNo { get; set; }
        public string? DrivingLicenceNo { get; set; }
        public string? ProspectusNo { get; set; }
        public string? OfflineBranchcode { get; set; }
        public string? DocumentNameList { get; set; }
        public string? FileName { get; set; }
    }
    public class StudentSearchDto
    {
        public string? Name { get; set; }
        public string? RegistrationNumber { get; set; }
        public string? Status { get; set; }
        public string? CenterCode { get; set; }
        public int? CourseId { get; set; }
        public int SessionId { get; set; }
        public List<ListItems>? StatusList { get; set; }
        public List<SelectListItem>? CourseList { get; set; }
        public List<ListItems>? SessionList { get; set; }
        public List<StudentResult1>? Results { get; set; }
    }
 
    public class StudentResult1
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string RegistrationNumber { get; set; }
        public string Course { get; set; }
        public string Status { get; set; }
        public string Session { get; set; }
        public string CenterCode { get; set; }
    }
    public class StudentCourseDetails
    {
        public int Sno { get; set; }
        public int StudentCourseFeeID { get; set; }
        public string RequestNo { get; set; }
        public int StudentID { get; set; }
        public string StudentName { get; set; }
        public string FatherName { get; set; }
        public string MotherName { get; set; }
        public string ContactAddress { get; set; }
        public string City { get; set; }
        public DateTime? DateOfJoining { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public string Pin { get; set; }
        public string EmailAddress { get; set; }
        public string MobileNo { get; set; }
        public DateTime? DOB { get; set; }

        public int? KIOSKID { get; set; }
        public int? ServiceID { get; set; }
        public int? CourseID { get; set; }
        public string CourseCategory { get; set; }
        public int? SessionID { get; set; }
        public string CourseDurationSession { get; set; }
        public int? Duration { get; set; }
        public string KIOSKCode { get; set; }
        public string ServiceName { get; set; }
        public string CourseName { get; set; }
        public string StudentStatus { get; set; }
        public string KIOSKName { get; set; }
        public string Gender { get; set; }
        public string Medium { get; set; }
        public string Category { get; set; }
        public string Scheme { get; set; }

        public DateTime? DispatchDate { get; set; }
        public DateTime? OrdGenDate { get; set; }
        public string DispatchNo { get; set; }
        public string DocketNo { get; set; }
        public string IsHOKIOSK { get; set; }
        public string ProspectusNo { get; set; }
        public string OfflineBranchcode { get; set; }

        public DateTime? AdminApprovalDate { get; set; }
        public DateTime? FinanceApprovalDate { get; set; }
        public string AdminComments { get; set; }
        public string ApprovedBy { get; set; }
        public string OldRequestNo { get; set; }
        public string KioskState { get; set; }
        public string ExamFormStatus { get; set; }
        public string ReRegistration { get; set; }

        public string EFTransId { get; set; }
        public DateTime? ExamFeeDate { get; set; }
        public string CFTransId { get; set; }
        public DateTime? CourseFeeDate { get; set; }

        public decimal? CourseFee { get; set; }
        public decimal? CourseFeePaid { get; set; }
        public string PaymentBy { get; set; }
        public decimal? CourseLateFee { get; set; }

        public decimal? ExamFee { get; set; }
        public decimal? ExamFeePaid { get; set; }
        public decimal? ExamLateFee { get; set; }
        public decimal? BacklogFeePaid { get; set; }

        public decimal? TotalFees { get; set; }
        public decimal? TotalFeePaid { get; set; }
        public decimal? FeeBalance { get; set; }

        public string MarksheetDispatched { get; set; }
        public string Subjects { get; set; }
    }


}

