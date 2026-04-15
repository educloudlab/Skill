using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentProgCourseMismatch
{
    public string? Name { get; set; }

    public string? Programmename { get; set; }

    public int StudentId { get; set; }

    public string RequestNo { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public DateTime Dob { get; set; }

    public string? Telephone { get; set; }

    public string ContactAddress { get; set; } = null!;

    public string? Pin { get; set; }

    public string MobileNo { get; set; } = null!;

    public string? FaxNo { get; set; }

    public string VillageTownCity { get; set; } = null!;

    public int District { get; set; }

    public int State { get; set; }

    public string EmailAddress { get; set; } = null!;

    public int AcademicQualification { get; set; }

    public int Sex { get; set; }

    public int Category { get; set; }

    public int IsPhysicallyHandicapped { get; set; }

    public int StudentBelongsTo { get; set; }

    public int Medium { get; set; }

    public string? OtherMedium { get; set; }

    public string MainSubject { get; set; } = null!;

    public int YearOfPassing { get; set; }

    public string Division { get; set; } = null!;

    public decimal MarksPercentage { get; set; }

    public string BoardCode { get; set; } = null!;

    public int Nationality { get; set; }

    public int MaritalStatus { get; set; }

    public int Religion { get; set; }

    public int WhetherMinority { get; set; }

    public int SocialStatus { get; set; }

    public int WhetherKashmiriMigrant { get; set; }

    public int WhetherPersonWithDisability { get; set; }

    public int NatureDisability { get; set; }

    public string? OtherNatureDisability { get; set; }

    public int EmploymentStatus { get; set; }

    public decimal AnnualScholarshipAmount { get; set; }

    public decimal? FamilyIncomeYearly { get; set; }

    public int DeptOfferingScholarship { get; set; }

    public int BelowPovertyLine { get; set; }

    public int KiosktypeId { get; set; }

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

    public string? BranchManager { get; set; }

    public bool? IsKiosk { get; set; }

    public string? AadharNo { get; set; }

    public string? DrivingLicenceNo { get; set; }

    public int? DrivingLicenceType { get; set; }

    public bool? IsHokiosk { get; set; }

    public string? CorresAddress { get; set; }

    public string? CorresPin { get; set; }

    public string? CorresVillageTownCity { get; set; }

    public int? CorresDistrict { get; set; }

    public int? CorresState { get; set; }

    public int? CourseMedium { get; set; }

    public string? CorresContactNo { get; set; }

    public string? UserId { get; set; }

    public string? Password { get; set; }

    public bool? LmsCsvSend { get; set; }

    public string? ProspectusNo { get; set; }

    public string? OfflineBranchcode { get; set; }

    public int StudentCourseFeeId { get; set; }

    public int SessionCourseFeeId { get; set; }

    public decimal RegistrationFee { get; set; }

    public decimal? RegistrationLateFee { get; set; }

    public decimal? RegistrationServiceTax { get; set; }

    public decimal TotalActualFee { get; set; }

    public decimal? TotalDiscount { get; set; }

    public int CourseId { get; set; }

    public int? SchemeId { get; set; }

    public int SessionId { get; set; }

    public bool Scfactive { get; set; }

    public int Scfstatus { get; set; }

    public string? Kioskremark { get; set; }

    public DateTime? KioskremarkDate { get; set; }

    public string? AdminRemark { get; set; }

    public DateTime? AdminRemarkDate { get; set; }

    public string? FinanceRemark { get; set; }

    public DateTime? FinanceRemarkDate { get; set; }

    public decimal? Kioskdiscount { get; set; }

    public string? CourseUpgraded { get; set; }

    public string? IsUpgraded { get; set; }
}
