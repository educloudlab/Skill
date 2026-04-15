using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Reg
{
    public string? RequestNo { get; set; }

    public string? TrackingNo { get; set; }

    public int? StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public int? StudentCourseFeeId { get; set; }

    public string? Status { get; set; }

    public string? KioskCode { get; set; }

    public string? KioskState { get; set; }

    public string? Course { get; set; }

    public string? Medium { get; set; }

    public string? Address { get; set; }

    public DateTime? DateOfJoining { get; set; }

    public int? District { get; set; }

    public string? State { get; set; }

    public string? Pin { get; set; }

    public DateTime? Dob { get; set; }

    public int? KioskId { get; set; }

    public int? ServiceId { get; set; }

    public int? CourseId { get; set; }

    public string? CourseCategory { get; set; }

    public string? KioskName { get; set; }

    public int? Duration { get; set; }

    public string? Gender { get; set; }

    public string? Category { get; set; }

    public bool? IsHokiosk { get; set; }

    public string? OfflineBranchCode { get; set; }

    public string? AcademicQualification { get; set; }

    public string? ReRegistration { get; set; }

    public DateTime? AdminApprovalDate { get; set; }

    public string? Session { get; set; }

    public string? University { get; set; }

    public string? Academy { get; set; }

    public string? CourseScheme { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailAddress { get; set; }

    public string? MainSubject { get; set; }

    public int? YearOfPassing { get; set; }

    public string? Division { get; set; }

    public decimal? MarksPercentage { get; set; }

    public string? BoardCode { get; set; }

    public DateTime? RegTransDate { get; set; }

    public string? RegTransId { get; set; }

    public decimal? RegTransAmount { get; set; }

    public DateTime? RegBalTransDate { get; set; }

    public string? RegBalTransId { get; set; }

    public decimal? RegBalTransAmount { get; set; }

    public decimal? TotalRegFeePaid { get; set; }
}
