using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CourseFeeSplit1
{
    public string? Course { get; set; }

    public string? Medium { get; set; }

    public double? TotalFees { get; set; }

    public double? TotalRegBooks { get; set; }

    public double? Books { get; set; }

    public double? AuCvruAsm { get; set; }

    public double? AuCvru { get; set; }

    public double? Asm { get; set; }

    public string? BranchShare { get; set; }

    public double? ExamFee { get; set; }

    public string? MediumId { get; set; }

    public string? Session { get; set; }
}
