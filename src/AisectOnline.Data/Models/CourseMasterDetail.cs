using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CourseMasterDetail
{
    public int CourseId { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public int? ProgrammeId { get; set; }

    public int? CourseCategory { get; set; }

    public int? UniversityId { get; set; }
}
