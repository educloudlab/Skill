using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class PancardRequest
{
    public int PanRequestId { get; set; }

    public string? UserHandle { get; set; }

    public string? TransId { get; set; }

    public string? Checksum { get; set; }

    public DateTime? RequestTime { get; set; }
}
