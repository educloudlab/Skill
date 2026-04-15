using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class SingleWalletTransactionLog
{
    public int KioskId { get; set; }

    public int CustomerId { get; set; }

    public string Kioskcode { get; set; } = null!;

    public decimal EWalletBalance { get; set; }

    public int ExpiredDays { get; set; }

    public string TransactionId { get; set; } = null!;

    public int TransactionStatus { get; set; }

    public string CsctransactionId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string? Service { get; set; }

    public double? CommAmount { get; set; }

    public double? Tdsamount { get; set; }

    public int? TransType { get; set; }
}
