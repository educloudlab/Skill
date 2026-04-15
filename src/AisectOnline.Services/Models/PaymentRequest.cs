using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PaymentRequest
{
    public int PaymentRequestId { get; set; }

    public string? VleId { get; set; }

    public string? MTrxId { get; set; }

    public decimal? Amount { get; set; }

    public string? ApplicationNo { get; set; }

    public DateTime? RequestTime { get; set; }

    public int? PanRequestId { get; set; }

    public int? EvoletTransactionId { get; set; }

    public DateTime? EvoletTransactionTime { get; set; }

    public string? RandomPaymentUniqueId { get; set; }
}
