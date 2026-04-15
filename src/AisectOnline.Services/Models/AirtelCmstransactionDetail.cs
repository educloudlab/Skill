using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AirtelCmstransactionDetail
{
    public int Cmsid { get; set; }

    public int? KioskId { get; set; }

    public string? FeSessionId { get; set; }

    public string? PaymentJson { get; set; }

    public string? TransactionAmount { get; set; }

    public string? CommissionAmount { get; set; }

    public string? AisecttxnId { get; set; }

    public DateTime? AisecttxnDate { get; set; }

    public string? AisectrefunTxnId { get; set; }

    public DateTime? AisectrefundTxnDate { get; set; }

    public string? RefundAmount { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public string? PaymentResJson { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
