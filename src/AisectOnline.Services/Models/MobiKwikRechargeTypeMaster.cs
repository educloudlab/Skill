using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MobiKwikRechargeTypeMaster
{
    public int Id { get; set; }

    public string? TypeName { get; set; }

    public double? AisectShare { get; set; }

    public double? BranchShare { get; set; }
}
