using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BajajLoanApiPaymentRequest
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public string? UniqueSessionId { get; set; }

    public string? ReqApiType { get; set; }

    public string? ReqLan { get; set; }

    public string? ReqToken { get; set; }

    public string? ReqPartnerId { get; set; }

    public string? ReqMerchantId { get; set; }

    public decimal? PaidAmount { get; set; }

    public string? AddtionalInfo { get; set; }

    public string? ReqPartnerTransId { get; set; }

    public string? ReqPaymentMode { get; set; }

    public string? ReqBankName { get; set; }

    public string? ReqWish { get; set; }

    public DateTime? ReqPaymentTxnDate { get; set; }

    public string? ReqRemarks { get; set; }

    public string? ReqField1 { get; set; }

    public string? ReqField2 { get; set; }

    public bool? ResFlag { get; set; }

    public string? ResMsg { get; set; }

    public string? ResBaflTxnId { get; set; }

    public string? AisecttxnId { get; set; }

    public int? KioskId { get; set; }

    public string? TxnOrderId { get; set; }

    public DateTime? AisecttxnDate { get; set; }

    public string? ResMsgcode { get; set; }

    public string? Aisectshare { get; set; }

    public string? BranchShare { get; set; }

    public string? ThirdPartShare { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
