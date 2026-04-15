using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class District
{
    public int DistrictId { get; set; }

    public string? DistrictName { get; set; }

    public int StateId { get; set; }

    public string StateName { get; set; } = null!;
}
