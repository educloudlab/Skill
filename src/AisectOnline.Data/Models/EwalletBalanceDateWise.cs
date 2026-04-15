using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class EwalletBalanceDateWise
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public double? Walletbalance { get; set; }

    public DateTime? TransactionDate { get; set; }
}
