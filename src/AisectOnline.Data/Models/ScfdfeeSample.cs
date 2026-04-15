using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ScfdfeeSample
{
    public string? EnrollmentNo { get; set; }

    public string Requestno { get; set; } = null!;

    public string? TrackingNo { get; set; }

    public int? DurationInMonths { get; set; }

    public string? StudentName { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? Pin { get; set; }

    public string Mobileno { get; set; } = null!;

    public string Emailaddress { get; set; } = null!;

    public DateTime Dob { get; set; }

    public string? Sex { get; set; }

    public string? Medium { get; set; }

    public string? Category { get; set; }

    public string? Subjects { get; set; }

    public int StudentId { get; set; }

    public string? Status { get; set; }

    public string? RefundStatus { get; set; }

    public string? RefundReversalTransId { get; set; }

    public DateTime? RefundReversalDate { get; set; }

    public string? AdminRemark { get; set; }

    public DateTime? AdminApprovalDate { get; set; }

    public string StateName { get; set; } = null!;

    public string? IsReregistered { get; set; }

    public string? Skill { get; set; }

    public string? AadharNo { get; set; }

    public int StudentCourseFeeId { get; set; }

    public decimal? Fee { get; set; }

    public decimal? CourseFee { get; set; }

    public string? ProgrammeName { get; set; }

    public string? Course { get; set; }

    public string? KioskCode { get; set; }

    public string? OldKioskCode { get; set; }

    public string? Session { get; set; }

    public decimal? TransactionAmount { get; set; }

    public DateTime CreatedDate { get; set; }

    public string University { get; set; } = null!;

    public string? Academy { get; set; }

    public string? TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public DateTime? FeereceivedDate { get; set; }

    public string? FeeType { get; set; }
}
