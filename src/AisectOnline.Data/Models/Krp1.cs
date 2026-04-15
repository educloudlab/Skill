using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Krp1
{
    public double? PaymentId { get; set; }

    public double? KioskId { get; set; }

    public double? KioskCode { get; set; }

    public double? RenewalCode { get; set; }

    public double? AcademyId { get; set; }

    public string? AcademyName { get; set; }

    public double? ProductId { get; set; }

    public double? OriginalAmount { get; set; }

    public double? Discount { get; set; }

    public double? FinalAmount { get; set; }

    public double? ServiceTaxAmount { get; set; }

    public double? CessAmount { get; set; }

    public double? TransactionId { get; set; }

    public string? BankReferenceNo { get; set; }

    public string? Remarks { get; set; }

    public double? PaymentMode { get; set; }

    public double? IsSubmitted { get; set; }

    public string? FinanceApprovalOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Year { get; set; }
}
