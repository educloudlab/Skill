using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CyberPlateRechargeDetail
{
    public int CyberPlateRechargeDetailId { get; set; }

    public int? KioskcustomerId { get; set; }

    public int? Kioskid { get; set; }

    public int? EWalletId { get; set; }

    public int? EWalletTransactionId { get; set; }

    public string? TransactionId { get; set; }

    public int? KioskserviceId { get; set; }

    public string? KioskserviceName { get; set; }

    public int? ServiceProviderId { get; set; }

    public string? ServiceProviderName { get; set; }

    public decimal? CommissionPercentage { get; set; }

    public string? SdDealerCode { get; set; }

    public string? ApAcceptanceCode { get; set; }

    public string? OpOperatorCode { get; set; }

    public int? ContentLength { get; set; }

    public string? MobileNo { get; set; }

    public string? NumberVeriSessionId { get; set; }

    public string? NumberVeriAccountNo { get; set; }

    public decimal? NumberVeriAmount { get; set; }

    public int? NumberVeriPayTool { get; set; }

    public string? NumberVeriPayToolName { get; set; }

    public string? NumberVeriTermId { get; set; }

    public string? NumberVeriComments { get; set; }

    public DateTime? NumberVeriResponseDate { get; set; }

    public string? NumberVeriResponseSession { get; set; }

    public int? NumberVeriResponseError { get; set; }

    public int? NumberVeriResponseResult { get; set; }

    public string? NumberVeriResponseOpname { get; set; }

    public string? NumberVeriResponseAccount { get; set; }

    public string? NumberVeriResponseErrorMsg { get; set; }

    public string? NumberVeriResponseAuthCode { get; set; }

    public string? NumberVeriResponseTransactionId { get; set; }

    public string? NumberVeriResponseAddInfo { get; set; }

    public string? PaymentReqSession { get; set; }

    public string? PaymentReqMobileNo { get; set; }

    public string? PaymentReqAccountNo { get; set; }

    public decimal? PaymentReqAmount { get; set; }

    public decimal? PaymentReqAmountAll { get; set; }

    public string? PaymentReqRrn { get; set; }

    public DateTime? PaymentReqDate { get; set; }

    public DateTime? PaymentReqResponseDate { get; set; }

    public string? PaymentReqResponseSession { get; set; }

    public int? PaymentReqResponseError { get; set; }

    public int? PaymentReqResponseResult { get; set; }

    public string? PaymentReqResponseTransactionId { get; set; }

    public decimal? ServiceTax { get; set; }

    public DateTime? SettlementDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? PaymentReqSd { get; set; }

    public string? PaymentReqAp { get; set; }

    public string? PaymentReqOp { get; set; }

    public int? PaymentReqPayTool { get; set; }

    public string? PaymentReqTermId { get; set; }

    public int? SuccessPaymentStatusCheckId { get; set; }

    public string? RechargeCustomerId { get; set; }

    public string? PaymentReqRchrgCustomerId { get; set; }

    public string? EmailId { get; set; }

    public decimal? CommissionAmt { get; set; }

    public decimal? AisServiceTaxAmt { get; set; }

    public decimal? AisTdsamt { get; set; }

    public int? CommissionCrtransId { get; set; }

    public bool? IsCommisionCr { get; set; }

    public string? NoVerificationUrl { get; set; }

    public string? PaymentReqUrl { get; set; }

    public decimal? BillAmount { get; set; }

    public decimal? TxnAmount { get; set; }

    public decimal? Aisectshare { get; set; }

    public decimal? BranchShare { get; set; }

    public decimal? ThirdPartShare { get; set; }

    public decimal? TotalAmt { get; set; }

    public virtual ICollection<CyberPlatePaymentStatusCheckDetail> CyberPlatePaymentStatusCheckDetails { get; set; } = new List<CyberPlatePaymentStatusCheckDetail>();

    public virtual ICollection<CyberPlateRechargeAuditTrail> CyberPlateRechargeAuditTrails { get; set; } = new List<CyberPlateRechargeAuditTrail>();

    public virtual Kioskdatum? Kiosk { get; set; }

    public virtual ServiceProviderMaster? ServiceProvider { get; set; }
}
