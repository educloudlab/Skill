using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class DinstaTransaction
{
    public int DitransactionId { get; set; }

    public string? KioskCode { get; set; }

    public int? TransactionId { get; set; }

    public string? OrderId { get; set; }

    public string? Token { get; set; }

    public double? Amount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? Status { get; set; }

    public string? Remark { get; set; }

    public string? PaymentResponse { get; set; }
}
