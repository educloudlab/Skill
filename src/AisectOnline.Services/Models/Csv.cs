using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Csv
{
    public int StudentCourseFeeId { get; set; }

    public string RequestNo { get; set; } = null!;

    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? ContactAddress { get; set; }

    public string? City { get; set; }

    public DateTime DateOfJoining { get; set; }

    public string District { get; set; } = null!;

    public string State { get; set; } = null!;

    public string? Pin { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public DateTime Dob { get; set; }

    public int Kioskid { get; set; }

    public int ServiceId { get; set; }

    public int CourseId { get; set; }

    public string? CourseCategory { get; set; }

    public string? CourseDurationSession { get; set; }

    public int? Duration { get; set; }

    public string? Kioskcode { get; set; }

    public string? ServiceName { get; set; }

    public string? CourseName { get; set; }

    public string? StudentStatus { get; set; }

    public string? Kioskname { get; set; }

    public string? Gender { get; set; }

    public string? Medium { get; set; }

    public string? Category { get; set; }

    public string? Scheme { get; set; }

    public DateTime? DispatchDate { get; set; }

    public DateTime? OrdGenDate { get; set; }

    public string? DispatchNo { get; set; }

    public string? DocketNo { get; set; }

    public string IsHokiosk { get; set; } = null!;

    public string? ProspectusNo { get; set; }

    public string? OfflineBranchcode { get; set; }

    public DateTime? AdminApprovalDate { get; set; }

    public string FinanceApprovalDate { get; set; } = null!;

    public string? AdminComments { get; set; }

    public string? ApprovedBy { get; set; }

    public string? OldRequestNo { get; set; }

    public string? KioskState { get; set; }

    public string? ExamFormStatus { get; set; }

    public string? ReRegistration { get; set; }

    public DateTime? ExamFeeDate { get; set; }

    public decimal? CourseFee { get; set; }

    public decimal? CourseFeePaid { get; set; }

    public decimal CourseLateFee { get; set; }

    public decimal? ExamFee { get; set; }

    public decimal? ExamFeePaid { get; set; }

    public decimal ExamLateFee { get; set; }

    public decimal BacklogFeePaid { get; set; }

    public decimal? TotalFees { get; set; }

    public decimal? TotalFeePaid { get; set; }

    public decimal? FeeBalance { get; set; }

    public string? Subjects { get; set; }
}
