using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PlacementBatchMaster
{
    public int BatchId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? Createdby { get; set; }
}
