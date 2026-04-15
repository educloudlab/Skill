using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CourseReregistration
{
    public double? CourseId { get; set; }

    public string? ShortName { get; set; }

    public double? Duration { get; set; }

    public double? ProgrammeId { get; set; }

    public double? CourseCode { get; set; }

    public double? Year { get; set; }
}
