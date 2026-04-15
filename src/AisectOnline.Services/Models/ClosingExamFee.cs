using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ClosingExamFee
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

    public string? Course { get; set; }

    public string? Medium { get; set; }

    public string? Address { get; set; }

    public DateTime? DateOfJoining { get; set; }

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

    public string University { get; set; } = null!;

    public string? Academy { get; set; }

    public string? CourseScheme { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailAddress { get; set; }

    public int? StateId { get; set; }

    public string? State { get; set; }

    public int? DistrictId { get; set; }

    public string? District { get; set; }

    public string? MainSubject { get; set; }

    public int? YearOfPassing { get; set; }

    public string? Division { get; set; }

    public decimal? MarksPercentage { get; set; }

    public string? BoardCode { get; set; }

    public DateTime? ExamTransDate { get; set; }

    public decimal? ExamTransAmount { get; set; }

    public decimal? BacklogTransAmount { get; set; }

    public decimal? TotalExamFeePaid { get; set; }
}
