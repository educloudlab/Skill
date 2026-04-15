using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class MpsosLateFee
{
    public int Id { get; set; }

    public string? ServiceName { get; set; }

    public int? ServiceFee { get; set; }

    public int? LateFee { get; set; }

    public DateTime? ValidStart { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
