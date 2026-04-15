using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskRenewalPayment04042024
{
    public int PaymentId { get; set; }

    public int? KioskId { get; set; }

    public string? KioskCode { get; set; }

    public string? RenewalCode { get; set; }

    public int? AcademyId { get; set; }

    public string? AcademyName { get; set; }

    public string? ProductId { get; set; }

    public int? OriginalAmount { get; set; }

    public int? Discount { get; set; }

    public int? FinalAmount { get; set; }

    public decimal? ServiceTaxAmount { get; set; }

    public decimal? CessAmount { get; set; }

    public string? TransactionId { get; set; }

    public string? BankReferenceNo { get; set; }

    public string? Remarks { get; set; }

    public int? PaymentMode { get; set; }

    public int? IsSubmitted { get; set; }

    public DateTime? FinanceApprovalOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Year { get; set; }

    public double? Rfees { get; set; }

    public double? Rdeposit { get; set; }

    public double? RserviceTax { get; set; }

    public int? RefundTxnId { get; set; }

    public DateTime? RefundTxnDate { get; set; }
}
