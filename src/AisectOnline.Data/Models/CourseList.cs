using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CourseList
{
    public double? CourseId { get; set; }

    public string? Course { get; set; }

    public double? Duration { get; set; }

    public string? ProgrammeName { get; set; }

    public string? CourseCategory { get; set; }

    public string? ServiceName { get; set; }
}
