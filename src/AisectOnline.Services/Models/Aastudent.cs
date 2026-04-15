using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Aastudent
{
    public double? SrNo { get; set; }

    public string? Name { get; set; }

    public string? Course { get; set; }

    public string? Session { get; set; }

    public string? ReqNo { get; set; }

    public double? StudentId { get; set; }

    public string? Status { get; set; }

    public double? OriginalFees { get; set; }

    public double? ConcessionalFeesToUpdate { get; set; }
}
