using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class SsisConfiguration
{
    public string ConfigurationFilter { get; set; } = null!;

    public string? ConfiguredValue { get; set; }

    public string PackagePath { get; set; } = null!;

    public string ConfiguredValueType { get; set; } = null!;
}
