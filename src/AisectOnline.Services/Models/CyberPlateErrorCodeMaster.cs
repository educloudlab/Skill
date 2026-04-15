using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CyberPlateErrorCodeMaster
{
    public int CyberPlateErrorCodeMasterId { get; set; }

    public int? ErrorCode { get; set; }

    public string? Description { get; set; }
}
