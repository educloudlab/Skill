using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class UpCenterLevelUpdation
{
    public int SrNo { get; set; }

    public string? StateName { get; set; }

    public string? District { get; set; }

    public string? BlockName { get; set; }

    public string? City { get; set; }

    public string? SkpId { get; set; }

    public string? NewCenterLevel { get; set; }
}
