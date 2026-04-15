using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Sheet1FeesAsk
{
    public double? Id { get; set; }

    public string? State { get; set; }

    public string? KioskCode { get; set; }

    public double? Pid { get; set; }

    public double? Customerid { get; set; }

    public string? Academy { get; set; }

    public double? AcademyFees { get; set; }

    public double? AguFees { get; set; }

    public double? PrvAcademyFees { get; set; }

    public double? AcademyFeesYn { get; set; }

    public double? AguFeesYn { get; set; }

    public string? Year { get; set; }

    public double? AcademyFeesTotal { get; set; }
}
