using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class WalletRefundStatus2
{
    public double? StudentId { get; set; }

    public string? KioskCode { get; set; }

    public string? RequestNo { get; set; }

    public string? StudentName { get; set; }

    public string? Course { get; set; }

    public double? TransactionAmount { get; set; }

    public double? TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? TransactionMode { get; set; }

    public string? TransactionType { get; set; }

    public string? RechargeStatus { get; set; }
}
