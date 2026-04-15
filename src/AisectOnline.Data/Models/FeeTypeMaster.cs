using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class FeeTypeMaster
{
    public int FeeTypeId { get; set; }

    public string? FeeType { get; set; }

    public bool? IsActive { get; set; }

    public decimal? ServiceTax { get; set; }

    public bool? IsLateFee { get; set; }

    public int? FtmgroupId { get; set; }

    public virtual ICollection<CourseFeeType> CourseFeeTypes { get; set; } = new List<CourseFeeType>();
}
