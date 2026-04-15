using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CyberPlateResultCodeMaster
{
    public int CyberPlateResultCodeMasterId { get; set; }

    public int? ResultCode { get; set; }

    public string? Description { get; set; }
}
