using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class PlacementBatchMaster2
{
    public int BatchId { get; set; }

    public int? BatchCount { get; set; }

    public string? PaymentStatus { get; set; }

    public int? TransactionId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? Createdby { get; set; }
}
