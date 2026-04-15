using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentFeeCsvBvoc
{
    public string RequestNo { get; set; } = null!;

    public string? TrackingNo { get; set; }

    public int StudentId { get; set; }

    public int StudentCourseFeeId { get; set; }

    public string? StudentName { get; set; }

    public string Mobileno { get; set; } = null!;

    public string Emailaddress { get; set; } = null!;

    public string? Sex { get; set; }

    public string? Category { get; set; }

    public string? FatherName { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? ProgrammeName { get; set; }

    public string? Course { get; set; }

    public string? Session { get; set; }

    public int? DurationInMonths { get; set; }

    public string? KioskCode { get; set; }

    public string? OldKioskCode { get; set; }

    public string? Status { get; set; }

    public string? RefundStatus { get; set; }

    public string? RefundReversalTransId { get; set; }

    public DateTime? RefundReversalDate { get; set; }

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

    public decimal? M1amount { get; set; }

    public string? M1transactionId { get; set; }

    public DateTime? M1transactionDate { get; set; }

    public decimal? M2amount { get; set; }

    public string? M2transactionId { get; set; }

    public DateTime? M2transactionDate { get; set; }

    public decimal? M3amount { get; set; }

    public string? M3transactionId { get; set; }

    public DateTime? M3transactionDate { get; set; }

    public decimal? M4amount { get; set; }

    public string? M4transactionId { get; set; }

    public DateTime? M4transactionDate { get; set; }

    public decimal? M5amount { get; set; }

    public string? M5transactionId { get; set; }

    public DateTime? M5transactionDate { get; set; }

    public decimal? M6amount { get; set; }

    public string? M6transactionId { get; set; }

    public DateTime? M6transactionDate { get; set; }

    public decimal? M7amount { get; set; }

    public string? M7transactionId { get; set; }

    public DateTime? M7transactionDate { get; set; }

    public decimal? M8amount { get; set; }

    public string? M8transactionId { get; set; }

    public DateTime? M8transactionDate { get; set; }

    public decimal? M9amount { get; set; }

    public string? M9transactionId { get; set; }

    public DateTime? M9transactionDate { get; set; }

    public decimal? M10amount { get; set; }

    public string? M10transactionId { get; set; }

    public DateTime? M10transactionDate { get; set; }

    public decimal? M11amount { get; set; }

    public string? M11transactionId { get; set; }

    public DateTime? M11transactionDate { get; set; }

    public decimal? M12amount { get; set; }

    public string? M12transactionId { get; set; }

    public DateTime? M12transactionDate { get; set; }

    public decimal? TotalPaid { get; set; }

    public decimal? Balance { get; set; }
}
