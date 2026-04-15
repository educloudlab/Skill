using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ItemInventoryMgmtDetail
{
    public int ItemInventoryMgmtDetailId { get; set; }

    public int? ItemId { get; set; }

    public int? SupplierId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? CostPerUnit { get; set; }

    public string? Remark { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
