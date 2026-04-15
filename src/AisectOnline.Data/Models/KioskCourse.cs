using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskCourse
{
    public int Sno { get; set; }

    public int? KioskId { get; set; }

    public string? CourseCode { get; set; }

    public double? FeePercentage { get; set; }
}
