using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class InsurancePaymentDetail
{
    public int InsurancePaymentDetailId { get; set; }

    public int? InsurancePaymentMasterId { get; set; }

    public int? KioskcustomerId { get; set; }

    public int? Kioskid { get; set; }

    public int? EWalletId { get; set; }

    public int? EWalletTransactionId { get; set; }

    public string? TransactionId { get; set; }

    public string? InsuranceTransactionId { get; set; }

    public string? SessionId { get; set; }

    public DateTime? DueDate { get; set; }

    public decimal? GrossAmount { get; set; }

    public decimal? SalesTax { get; set; }

    public decimal? CommissionPercentage { get; set; }

    public decimal? InterestAmount { get; set; }

    public string? ProductCode { get; set; }

    public int? OrderNo { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? IsSuccess { get; set; }

    public decimal? ServiceTax { get; set; }

    public string? MerchantId { get; set; }

    public string? AisectIdno { get; set; }

    public decimal? PremiumAmount { get; set; }

    public string? UpdateTxnReqMerchantId { get; set; }

    public int? UpdateTxnReqOrderNo { get; set; }

    public string? UpdateTxnReqTxnReferenceNo { get; set; }

    public decimal? UpdateTxnReqTxnAmount { get; set; }

    public DateTime? UpdateTxnReqTxnDate { get; set; }

    public int? UpdateTxnReqAuthStatus { get; set; }

    public string? UpdateTxnReqSettlementType { get; set; }

    public string? UpdateTxnReqAdditionalInfo1 { get; set; }

    public string? UpdateTxnReqAdditionalInfo2 { get; set; }

    public string? UpdateTxnReqAdditionalInfo3 { get; set; }

    public string? UpdateTxnReqAdditionalInfo4 { get; set; }

    public string? UpdateTxnReqAdditionalInfo5 { get; set; }

    public string? UpdateTxnReqAdditionalInfo6 { get; set; }

    public string? UpdateTxnReqAdditionalInfo7 { get; set; }

    public int? UpdateTxnReqErrorStatus { get; set; }

    public string? UpdateTxnReqErrorDescription { get; set; }

    public string? GetPremiumDtlResErrorCode { get; set; }

    public string? GetPremiumDtlResErrorDescription { get; set; }

    public string? GetPremiumDtlResPolicyNo { get; set; }

    public string? UpdateTxnResponse { get; set; }

    public DateTime? UpdateTxnResponseDate { get; set; }

    public DateTime? UpdateTxnReqDate { get; set; }

    public DateTime? GetPremiumDtlResDate { get; set; }

    public bool? IsEodMissend { get; set; }

    public decimal? CommissionAmt { get; set; }

    public decimal? AisServiceTaxAmt { get; set; }

    public decimal? AisTdsamt { get; set; }

    public int? CommissionCrtransId { get; set; }

    public bool? IsCommisionCr { get; set; }

    public virtual EWalletTransaction? EWalletTransaction { get; set; }

    public virtual InsurancePaymentMaster? InsurancePaymentMaster { get; set; }

    public virtual Kioskdatum? Kiosk { get; set; }
}
