using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PackageMaster
{
    public int PackageId { get; set; }

    public string? PackageName { get; set; }

    public int? Amount { get; set; }
}
