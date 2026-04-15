using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Mi1
{
    public string RequestNo { get; set; } = null!;

    public int StudentId { get; set; }

    public string? StudentName { get; set; }

    public int CourseId { get; set; }

    public string? CourseName { get; set; }

    public int ProgrammeId { get; set; }

    public string? Programmename { get; set; }

    public decimal? Fee { get; set; }

    public string? SessionName { get; set; }

    public int SessionId { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public int StudentCourseFeeId { get; set; }

    public int ServiceId { get; set; }

    public int? TransactionId { get; set; }

    public int? BankRefNo { get; set; }

    public string? Kiosk { get; set; }

    public string? Kiosktype { get; set; }

    public string? Kioskservice { get; set; }

    public string? Kioskremark { get; set; }

    public string? AdminRemark { get; set; }

    public string? FinanceRemark { get; set; }

    public string? FatherName { get; set; }

    public DateTime Dob { get; set; }

    public int? Duration { get; set; }

    public string? Scheme { get; set; }

    public string? Status { get; set; }

    public string? ProspectusNo { get; set; }

    public string? OfflineBranchcode { get; set; }

    public string? ApprovedBy { get; set; }

    public string ExamFormStatus { get; set; } = null!;

    public int ExamFee { get; set; }

    public string RegistrationType { get; set; } = null!;

    public DateTime CreatedOn { get; set; }

    public string? KioskState { get; set; }
}
