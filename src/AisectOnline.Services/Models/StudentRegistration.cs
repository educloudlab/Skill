using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentRegistration
{
    public int StudentregId { get; set; }

    public string Kiosktype { get; set; } = null!;

    public string? Service { get; set; }

    public string? Kioskcode { get; set; }

    public string? BranchManager { get; set; }

    public int ProgrammeId { get; set; }

    public int? CourseMedium { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public DateTime Dob { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string? FaxNo { get; set; }

    public string? Paddress { get; set; }

    public string Pcity { get; set; } = null!;

    public string? Pin { get; set; }

    public int State { get; set; }

    public string? Telephone { get; set; }

    public int District { get; set; }

    public string? CorresAddress { get; set; }

    public string? CorresCity { get; set; }

    public string? CorresPin { get; set; }

    public int? CorresState { get; set; }

    public string? CorresContactNo { get; set; }

    public int? CorresDistrict { get; set; }

    public int Sex { get; set; }

    public int MaritalStatus { get; set; }

    public int Category { get; set; }

    public string? LicenceType { get; set; }

    public string? AadharNo { get; set; }

    public int AcademicQualification { get; set; }

    public string MainSubject { get; set; } = null!;

    public int YearOfPassing { get; set; }

    public string Division { get; set; } = null!;

    public decimal MarksPercentage { get; set; }

    public string BoardCode { get; set; } = null!;

    public int Medium { get; set; }

    public int StudentBelongsTo { get; set; }

    public int Nationality { get; set; }

    public decimal? FamilyIncomeYearly { get; set; }

    public int KiosktypeId { get; set; }

    public int ServiceId { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public bool IsActive { get; set; }

    public int Status { get; set; }

    public int Kioskid { get; set; }

    public string? UserId { get; set; }

    public string? Password { get; set; }

    public string? DocsSubmittedString { get; set; }

    public string? StudentImgPhoto { get; set; }

    public string? StudentImgTenth { get; set; }

    public string? StudentImgTwilth { get; set; }

    public string? StudentImgGradute { get; set; }

    public string? StudentImgDob { get; set; }

    public string? StudentImgCast { get; set; }
}
