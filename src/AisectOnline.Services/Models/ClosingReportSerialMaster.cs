using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ClosingReportSerialMaster
{
    public int Id { get; set; }

    public string? ServiceName { get; set; }

    public int? SerialNumber { get; set; }

    public string? Aggregator { get; set; }

    public int? IsActive { get; set; }
}
