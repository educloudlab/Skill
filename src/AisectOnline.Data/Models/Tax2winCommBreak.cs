using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Tax2winCommBreak
{
    public int PlanId { get; set; }

    public string? PlanName { get; set; }

    public int? Tax2Win { get; set; }

    public int? Aisectltd { get; set; }

    public int? Total1 { get; set; }

    public int? Gst { get; set; }

    public int? CustomerPrice { get; set; }

    public double? AisectltdsharePerc { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? AmountRefund { get; set; }
}
