using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CyberPlatePaymentStatusCheckDetail
{
    public int CyberPlatePaymentStatusCheckId { get; set; }

    public int? CyberPlateRechargeDetailId { get; set; }

    public string? PaymentStatusCheckSession { get; set; }

    public string? PaymentStatusCheckTransactionId { get; set; }

    public DateTime? PaymentStatusCheckResponseDate { get; set; }

    public string? PaymentStatusCheckResponseSession { get; set; }

    public int? PaymentStatusCheckResponseError { get; set; }

    public int? PaymentStatusCheckResponseResult { get; set; }

    public string? PaymentStatusCheckResponseAuthCode { get; set; }

    public string? PaymentStatusCheckResponseTransactionId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? PayStatusCheckUrl { get; set; }

    public bool? IsStatusChecked { get; set; }

    public virtual CyberPlateRechargeDetail? CyberPlateRechargeDetail { get; set; }
}
