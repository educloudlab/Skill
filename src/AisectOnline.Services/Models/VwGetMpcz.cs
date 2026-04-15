using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class VwGetMpcz
{
    public DateOnly? TransactionDate { get; set; }

    public string? TransactionType { get; set; }

    public int? TotalTransactions { get; set; }

    public decimal? TotalTransactionAmount { get; set; }
}
