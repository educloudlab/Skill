using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ProgrammeMappingMaster
{
    public string? ProgrammeId { get; set; }

    public string? Courseid { get; set; }

    public string? Kioskserviceid { get; set; }

    public string? CourseCategoryId { get; set; }

    public string? Duration { get; set; }

    public string? FullCourseDurationYear { get; set; }

    public string? ProgrammeName { get; set; }

    public string? CourseName { get; set; }

    public string? ShortName { get; set; }

    public string? ServiceName { get; set; }

    public string? CourseCategory { get; set; }

    public string? ProgrammeCode { get; set; }

    public string? ProgrammeCourseCode { get; set; }
}
