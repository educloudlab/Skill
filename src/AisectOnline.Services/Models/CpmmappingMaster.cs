using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CpmmappingMaster
{
    public int CpmmappingId { get; set; }

    public int? CourseCategoryId { get; set; }

    public int? ProgrammeId { get; set; }

    public int? CourseId { get; set; }

    public int? MediumId { get; set; }

    public string? CpmmappingCode { get; set; }

    public int? NoOfOptionalSub { get; set; }

    public virtual ICollection<BookSubjectMaster> BookSubjectMasters { get; set; } = new List<BookSubjectMaster>();

    public virtual ICollection<CourseItemMaster> CourseItemMasters { get; set; } = new List<CourseItemMaster>();
}
