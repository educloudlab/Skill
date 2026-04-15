using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AlmappingBkup
{
    public int AlmappingId { get; set; }

    public int? CourseId { get; set; }

    public string? Aocourse { get; set; }

    public string? AocourseCode { get; set; }

    public string? Alcourse { get; set; }

    public string? AlcourseCode { get; set; }
}
