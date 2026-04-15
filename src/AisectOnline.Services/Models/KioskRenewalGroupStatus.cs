using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskRenewalGroupStatus
{
    public string? Pid { get; set; }

    public string? Fees { get; set; }

    public bool? Status { get; set; }

    public string? Year { get; set; }
}
