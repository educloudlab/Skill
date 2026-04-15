using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace AisectOnline.Data.Models;

public partial class CourseCategory
{
    public int CourseCategoryId { get; set; }

    public string? CourseCategory1 { get; set; }

    [NotMapped]
    public bool? IsActive { get; set; }
    [NotMapped]
    public int? SectorId { get; set; }
    [NotMapped]
    public virtual ICollection<ProgrammeMaster> ProgrammeMasters { get; set; } = new List<ProgrammeMaster>();
}
