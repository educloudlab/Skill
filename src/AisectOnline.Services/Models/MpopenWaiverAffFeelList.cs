using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MpopenWaiverAffFeelList
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public double? Fees { get; set; }

    public double? ActualFeed { get; set; }

    public DateOnly? CreatedOn { get; set; }

    public bool? IsPaid { get; set; }

    public string? RenewalYear { get; set; }
}
