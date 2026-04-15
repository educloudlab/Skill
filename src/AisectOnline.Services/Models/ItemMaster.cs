using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ItemMaster
{
    public int ItemId { get; set; }

    public string? ItemName { get; set; }

    public decimal? ItemPrice { get; set; }

    public int? SupplierId { get; set; }

    public int? ReOrderPoint { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? ItemCode { get; set; }

    public virtual ICollection<CourseItemMaster> CourseItemMasters { get; set; } = new List<CourseItemMaster>();

    public virtual MasterList? Supplier { get; set; }
}
