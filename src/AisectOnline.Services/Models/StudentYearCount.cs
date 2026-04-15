using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentYearCount
{
    public string? KioskCode { get; set; }

    public int Studentid { get; set; }

    public string RequestNo { get; set; } = null!;

    public string? Session { get; set; }

    public int? Count { get; set; }

    public int? FullCourseDurationYear { get; set; }
}
