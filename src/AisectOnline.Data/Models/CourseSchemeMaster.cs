using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CourseSchemeMaster
{
    public int CourseSchemeId { get; set; }

    public string? CourseScheme { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<CourseFee> CourseFees { get; set; } = new List<CourseFee>();

    public virtual ICollection<StudentCourseFee> StudentCourseFees { get; set; } = new List<StudentCourseFee>();
}
