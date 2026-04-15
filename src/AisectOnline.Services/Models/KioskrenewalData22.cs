using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskrenewalData22
{
    public string? Id { get; set; }

    public string? State { get; set; }

    public string? KioskCode { get; set; }

    public string? Pid { get; set; }

    public string? Customerid { get; set; }

    public string? Academy { get; set; }

    public double? AcademyFees { get; set; }

    public double? AguFees { get; set; }

    public double? PrvAcademyFees { get; set; }

    public string? AcademyFeesYn { get; set; }

    public string? AguFeesYn { get; set; }

    public string? Year { get; set; }

    public double? AcademyFeesTotal { get; set; }
}
