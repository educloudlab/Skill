using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentProfile
{
    public int AuxId { get; set; }

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public DateTime Dob { get; set; }

    public string? Telephone { get; set; }

    public string? ContactAddress { get; set; }

    public string? Pin { get; set; }

    public string MobileNo { get; set; } = null!;

    public string? FaxNo { get; set; }

    public string? VillageTownCity { get; set; }

    public int? District { get; set; }

    public int? State { get; set; }

    public string? EmailAddress { get; set; }

    public int? AcademicQualification { get; set; }

    public int? Sex { get; set; }

    public int? Category { get; set; }

    public int? StudentBelongsTo { get; set; }

    public int? Medium { get; set; }

    public string? OtherMedium { get; set; }

    public string? MainSubject { get; set; }

    public int? YearOfPassing { get; set; }

    public string? Division { get; set; }

    public decimal? MarksPercentage { get; set; }

    public string? BoardCode { get; set; }

    public int? Nationality { get; set; }

    public int MaritalStatus { get; set; }

    public int? Religion { get; set; }

    public int? SocialStatus { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public int Kioskid { get; set; }

    public bool? IsKiosk { get; set; }

    public string? AadharNo { get; set; }

    public string? CorresAddress { get; set; }

    public string? CorresPin { get; set; }

    public string? CorresVillageTownCity { get; set; }

    public int? CorresDistrict { get; set; }

    public int? CorresState { get; set; }

    public string? CorresContactNo { get; set; }

    public int? DrivingLicenceType { get; set; }
}
