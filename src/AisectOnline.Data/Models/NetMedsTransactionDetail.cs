using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class NetMedsTransactionDetail
{
    public int Id { get; set; }

    public int KioskId { get; set; }

    public string? KioskCode { get; set; }

    public string? OperatorCode { get; set; }

    public string? OperatorName { get; set; }

    public string? ConsumerNo { get; set; }

    public string? BillDate { get; set; }

    public string? BillDueDate { get; set; }

    public string? BillNumber { get; set; }

    public string? AisectorderId { get; set; }

    public string? OrderId { get; set; }

    public string? TokenKey { get; set; }

    public string? NetmedOrderId { get; set; }

    public string? NetmedUserCode { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? OperatorTransactionId { get; set; }

    public string AisecttransactionId { get; set; } = null!;

    public DateTime? AisecttxnDate { get; set; }

    public string? TxnStatus { get; set; }

    public string? TxnMessage { get; set; }

    public string? TxnResponseCode { get; set; }

    public string? TxnRefundAmount { get; set; }

    public DateTime? EnterDate { get; set; }

    public string? Charge { get; set; }

    public string? Commission { get; set; }

    public string? Error { get; set; }

    public string? PartnerReqId { get; set; }

    public string? UserVar1 { get; set; }

    public string? UserVar2 { get; set; }

    public string? UserVar3 { get; set; }

    public decimal? TotalAmt { get; set; }

    public decimal? BillAmount { get; set; }

    public decimal? TxnAmount { get; set; }

    public decimal? Aisectshare { get; set; }

    public decimal? BranchShare { get; set; }

    public decimal? ThirdPartShare { get; set; }
}
