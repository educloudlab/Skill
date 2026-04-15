using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class InsuranceEodMisreport
{
    public int InsuranceEodMisreportId { get; set; }

    public string? BillerId { get; set; }

    public string? Franchisee { get; set; }

    public string? FranchiseeRefNo { get; set; }

    public string? Kvbidno { get; set; }

    public string? Ref1 { get; set; }

    public string? Ref2 { get; set; }

    public string? Ref3 { get; set; }

    public string? Ref4 { get; set; }

    public string? Ref5 { get; set; }

    public string? Ref6 { get; set; }

    public string? Ref7 { get; set; }

    public string? Ref8 { get; set; }

    public string? Filler { get; set; }

    public DateTime? DateTimeOfTxn { get; set; }

    public DateTime? SettlementDate { get; set; }

    public decimal? GrossAmountRsPs { get; set; }

    public decimal? ChargesRsPs { get; set; }

    public decimal? StaxRsPs { get; set; }

    public decimal? NetAmountRsPs { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? InsurancePaymentDetailId { get; set; }

    public int? InsuranceEodMasterId { get; set; }
}
