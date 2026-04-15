using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BlockMaster
{
    public int DistrictId { get; set; }

    public int BlockId { get; set; }

    public string? BlockName { get; set; }
}
