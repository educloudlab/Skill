using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class RecallStudent
{
    public string? RequestNo { get; set; }

    public string? TrackingNo { get; set; }

    public double? StudentId { get; set; }

    public string? StudentName { get; set; }

    public string F5 { get; set; } = null!;

    public string F6 { get; set; } = null!;
}
