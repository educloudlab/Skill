using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Tax2winResPaymentConf
{
    public int Id { get; set; }

    public string? KioskId { get; set; }

    public string? EnCode { get; set; }

    public string? TransactionId { get; set; }

    public string? MerchantId { get; set; }

    public string? MerchantCode { get; set; }

    public string? Timestamp { get; set; }

    public string? CustomerPrice { get; set; }

    public string? PlanName { get; set; }

    public string? PlanAmount { get; set; }

    public string? PlanCommission { get; set; }

    public string? Consumername { get; set; }

    public string? TransactionOther1 { get; set; }

    public string? TransactionOther2 { get; set; }

    public string? TransactionOther3 { get; set; }

    public string? AisecttxnId { get; set; }

    public string? AisecttxnDate { get; set; }

    public string? PlanName1 { get; set; }

    public string? Tax2Win { get; set; }

    public string? Aisectltd { get; set; }

    public string? Total1 { get; set; }

    public string? Gst { get; set; }

    public string? CustomerPrice1 { get; set; }

    public double? AisectltdsharePerc { get; set; }

    public double? BranchSharePerc { get; set; }

    public DateTime? Createdon { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public string? IsRefunded { get; set; }
}
