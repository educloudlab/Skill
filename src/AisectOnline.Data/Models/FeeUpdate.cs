using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class FeeUpdate
{
    public string? KioskCode { get; set; }

    public string? AcademyFees { get; set; }

    public double? AcademyFeesWithLateFees { get; set; }

    public string? AguFees { get; set; }

    public double? AguFeesWithLateFees { get; set; }

    public double? PrvAcademyFees { get; set; }

    public double? AcademyFeesTotal { get; set; }
}
