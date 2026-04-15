using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Studentcoursefee29042025
{
    public int StudentCourseFeeId { get; set; }

    public int StudentId { get; set; }

    public int SessionCourseFeeId { get; set; }

    public decimal RegistrationFee { get; set; }

    public decimal? RegistrationLateFee { get; set; }

    public decimal? RegistrationServiceTax { get; set; }

    public decimal TotalActualFee { get; set; }

    public decimal? TotalDiscount { get; set; }

    public int CourseId { get; set; }

    public int? SchemeId { get; set; }

    public int SessionId { get; set; }

    public DateTime CreatedDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedDate { get; set; }

    public int? UpdatedBy { get; set; }

    public bool IsActive { get; set; }

    public int Status { get; set; }

    public string? Kioskremark { get; set; }

    public DateTime? KioskremarkDate { get; set; }

    public string? AdminRemark { get; set; }

    public DateTime? AdminRemarkDate { get; set; }

    public string? FinanceRemark { get; set; }

    public DateTime? FinanceRemarkDate { get; set; }

    public decimal? Kioskdiscount { get; set; }

    public string? CourseUpgraded { get; set; }

    public string? IsUpgraded { get; set; }

    public string? MarksheetDispatch { get; set; }

    public string? DispatchRemark { get; set; }

    public string? DateDispatch { get; set; }

    public string? TransferRemark { get; set; }

    public string? BookDispatch { get; set; }

    public string? MigrationDispatch { get; set; }

    public string? MigrationDispatchRem { get; set; }

    public DateTime? MigrationDispatchDate { get; set; }

    public string? DegreeDispatch { get; set; }

    public string? DegreeDispatchRem { get; set; }

    public DateTime? DegreeDispatchDate { get; set; }

    public string? Wesdispatch { get; set; }

    public string? WesdispatchRem { get; set; }

    public DateTime? WesdispatchDate { get; set; }

    public string? TranscriptDispatch { get; set; }

    public string? TranscriptDispatchRem { get; set; }

    public DateTime? TranscriptDispatchDate { get; set; }

    public bool? AllowBookDispatch { get; set; }
}
