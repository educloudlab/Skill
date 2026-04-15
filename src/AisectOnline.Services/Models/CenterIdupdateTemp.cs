using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CenterIdupdateTemp
{
    public string? Skpid { get; set; }

    public string? OldCentreType { get; set; }

    public string? NewCentreType { get; set; }

    public double? NewCenterTypeId { get; set; }
}
