using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceAndProductsTransactionDetail
{
    public int CyberPlateTransactionDetailId { get; set; }

    public int? CyberPlateRechargeDetailId { get; set; }

    public int? KioskcustomerId { get; set; }

    public int? Kioskid { get; set; }

    public int? TransactionId { get; set; }

    public int? EWalletTransactionId { get; set; }

    public decimal? EWalletTotalBalance { get; set; }

    public decimal? AmountPaid { get; set; }

    public decimal? EWalletBalAfterDeduction { get; set; }

    public string? PayStatus { get; set; }

    public int? KioskserviceId { get; set; }

    public int? ServiceProviderId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? InsurancePaymentDetailId { get; set; }
}
