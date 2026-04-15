using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CoursemasterTesting
{
    public int CourseId { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public int? Duration { get; set; }

    public int? ProgrammeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? CourseMedium { get; set; }

    public string? CourseCode { get; set; }

    public int? FullCourseDurationYear { get; set; }

    public int? Courseyear { get; set; }

    public string? GroupCode { get; set; }

    public string? KioskServiceId { get; set; }
}
