using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Recharge
{
    public string Kioskcode { get; set; } = null!;

    public DateTime? TransactionDate { get; set; }

    public decimal TransactionAmount { get; set; }

    public string? Remark { get; set; }
}
