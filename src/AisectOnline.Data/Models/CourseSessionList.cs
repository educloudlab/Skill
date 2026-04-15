using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CourseSessionList
{
    public string? Course { get; set; }

    public int? Duration { get; set; }

    public string? Session { get; set; }

    public DateTime? SessionStartDate { get; set; }

    public DateTime? SessionEndDate { get; set; }

    public string? ProgrammeName { get; set; }

    public string? CourseCategory { get; set; }

    public string ServiceName { get; set; } = null!;
}
