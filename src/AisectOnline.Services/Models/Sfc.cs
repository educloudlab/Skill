using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Sfc
{
    public string? EnrollmentNo { get; set; }

    public string RequestNo { get; set; } = null!;

    public string? TrackingNo { get; set; }

    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public string Mobileno { get; set; } = null!;

    public string Emailaddress { get; set; } = null!;

    public string? Sex { get; set; }

    public string? Category { get; set; }

    public string? FatherName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public int StudentCourseFeeId { get; set; }

    public string? ProgrammeName { get; set; }

    public string? Course { get; set; }

    public string? Session { get; set; }

    public int? DurationInMonths { get; set; }

    public string? KioskCode { get; set; }

    public string? OldKioskCode { get; set; }

    public string? Status { get; set; }

    public DateTime Doj { get; set; }

    public string University { get; set; } = null!;

    public string? Academy { get; set; }

    public string? AdminRemark { get; set; }

    public DateTime? AdminApprovalDate { get; set; }

    public string StateName { get; set; } = null!;

    public string? IsReregistered { get; set; }

    public string? Skill { get; set; }

    public string? AadharNo { get; set; }

    public decimal? CourseFee { get; set; }

    public decimal? EnrollmentFee { get; set; }

    public decimal? Registration { get; set; }

    public decimal? RegistrationBalance { get; set; }

    public decimal? TutionFee { get; set; }

    public decimal? Exam { get; set; }

    public decimal? Backlog { get; set; }

    public decimal? CounselingFee1 { get; set; }

    public decimal? CounselingFee2 { get; set; }

    public string? Mothername { get; set; }

    public string? ApprovedBy { get; set; }

    public decimal? EnrollmentFeePaid { get; set; }

    public decimal? RegTransAmount { get; set; }

    public decimal? RegLateFee { get; set; }

    public DateTime? RegTransDate { get; set; }

    public string? RegTransId { get; set; }

    public decimal? RegBalTransAmount { get; set; }

    public DateTime? RegBalTransDate { get; set; }

    public string? RegBalTransId { get; set; }

    public decimal? TutionFeePaid { get; set; }

    public decimal? ExamTransAmount { get; set; }

    public decimal? ExamLateFee { get; set; }

    public DateTime? ExamTransDate { get; set; }

    public string? ExamTransId { get; set; }

    public decimal? BacklogTransAmount { get; set; }

    public decimal? Couns1TransAmount { get; set; }

    public DateTime? Couns1TransDate { get; set; }

    public string? Couns1TransId { get; set; }

    public decimal? Couns2TransAmount { get; set; }

    public DateTime? Couns2TransDate { get; set; }

    public string? Couns2TransId { get; set; }

    public decimal? TotalRegFeePaid { get; set; }

    public decimal? TotalCounsellingFeePaid { get; set; }

    public decimal? TotalExamFeePaid { get; set; }
}
