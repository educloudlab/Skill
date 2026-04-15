using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CourseFeeSplit2
{
    public double? Sno { get; set; }

    public int UniversityId { get; set; }

    public string? UniversityName { get; set; }

    public string? Programme { get; set; }

    public string? Course { get; set; }

    public string? Medium { get; set; }

    public double? TotalRegistrationAmt { get; set; }

    public double? AisectLtdAmt { get; set; }

    public double? UniversityAsmamt { get; set; }

    public double? UniversityAmt { get; set; }

    public double? Asmamt { get; set; }

    public int? ServiceType { get; set; }

    public string? Session { get; set; }

    public double? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedOn { get; set; }
}
