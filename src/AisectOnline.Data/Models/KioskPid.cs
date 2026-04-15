using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskPid
{
    public string? Pid { get; set; }

    public double? Fees { get; set; }

    public string Paid { get; set; } = null!;
}
