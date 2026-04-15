using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BalanceAmountDatum
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? KioskCode { get; set; }

    public decimal? Amount { get; set; }

    public int? TransactionId { get; set; }

    public int? PaymentStatus { get; set; }

    public string? UniqueSessionId { get; set; }

    public string? Description { get; set; }

    public DateTime? CreatedOn { get; set; }
}
