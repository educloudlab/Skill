using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Almapping
{
    public int AlmappingId { get; set; }

    public int? CourseId { get; set; }

    public string? Aocourse { get; set; }

    public string? AocourseCode { get; set; }

    public string? Alcourse { get; set; }

    public string? AlcourseCode { get; set; }
}
