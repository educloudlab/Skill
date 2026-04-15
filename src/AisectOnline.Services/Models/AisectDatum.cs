using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AisectDatum
{
    public int? Sno { get; set; }

    public string? State { get; set; }

    public string? District { get; set; }

    public string? KioskCode { get; set; }

    public string? City { get; set; }

    public string? StateCode { get; set; }

    public string? DistrictCode { get; set; }

    public string? SubDistictCode { get; set; }

    public string? VillageCode { get; set; }

    public string? Coverage { get; set; }

    public int? CustomerId { get; set; }
}
