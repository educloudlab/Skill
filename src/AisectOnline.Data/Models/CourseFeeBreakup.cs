using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CourseFeeBreakup
{
    public double? Sno { get; set; }

    public string? University { get; set; }

    public string? Course { get; set; }

    public string? Medium { get; set; }

    public double? TotalRegBooks { get; set; }

    public double? Books { get; set; }

    public double? AuCvruAsm { get; set; }

    public double? AuCvru { get; set; }

    public double? Asm { get; set; }
}
