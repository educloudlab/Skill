using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class DistrictMaster
{
    public string? StateCode { get; set; }

    public int DistrictId { get; set; }

    public string? DistrictName { get; set; }

    public int StateId { get; set; }
}
