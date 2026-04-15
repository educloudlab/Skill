using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Tax2winScheduleOfFee
{
    public int? PlanId { get; set; }

    public string? PlanName { get; set; }

    public string? Tax2Win { get; set; }

    public string? TotalShare { get; set; }

    public string? Vleshare { get; set; }

    public string? Aisectshare { get; set; }

    public string? BasicAmount { get; set; }

    public string? Gst { get; set; }

    public string? CustomerPrice { get; set; }

    public string? Gstpercent { get; set; }

    public string? Aisectpercent { get; set; }

    public DateTime? CreatedOn { get; set; }
}
