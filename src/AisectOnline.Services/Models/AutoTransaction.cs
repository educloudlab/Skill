using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AutoTransaction
{
    public long TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? IsBulkInsert { get; set; }
}
