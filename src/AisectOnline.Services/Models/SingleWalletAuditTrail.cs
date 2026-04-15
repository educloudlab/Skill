using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class SingleWalletAuditTrail
{
    public long SingleWalletTransactionId { get; set; }

    public int? TransactionId { get; set; }

    public string? CsctransactionId { get; set; }

    public string? VleId { get; set; }

    public int? KioskId { get; set; }

    public string? SessionId { get; set; }

    public string? Type { get; set; }

    public string? RequestParam { get; set; }

    public string? ResponseParam { get; set; }

    public string? Status { get; set; }

    public string? StatusMsg { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? CreatedBy { get; set; }

    public double? Amount { get; set; }

    public double? CommAmount { get; set; }

    public double? Tdsamount { get; set; }

    public string? Service { get; set; }
}
