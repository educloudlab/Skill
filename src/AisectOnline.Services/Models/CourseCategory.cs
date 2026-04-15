using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CourseCategory
{
    public int CourseCategoryId { get; set; }

    public string? CourseCategory1 { get; set; }

    public bool? IsActive { get; set; }

    public int? SectorId { get; set; }

    public virtual ICollection<ProgrammeMaster> ProgrammeMasters { get; set; } = new List<ProgrammeMaster>();
}
