using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class NewFee
{
    public string? Course { get; set; }

    public double? CourseCode { get; set; }

    public double? Fee { get; set; }

    public double? NewFees { get; set; }

    public double? FeeTypeId { get; set; }

    public string? FeeType { get; set; }

    public double? SchemeId { get; set; }

    public double? CourseId { get; set; }

    public string? CourseFeeName { get; set; }
}
