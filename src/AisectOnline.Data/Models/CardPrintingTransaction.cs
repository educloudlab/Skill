using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CardPrintingTransaction
{
    public int Id { get; set; }

    public string? License { get; set; }

    public decimal? Amount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? KioskCode { get; set; }

    public int? PaymentStatus { get; set; }
}
