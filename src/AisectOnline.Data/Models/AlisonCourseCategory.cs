using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AlisonCourseCategory
{
    public string CategoryId { get; set; } = null!;

    public string? Category { get; set; }

    public bool? DisplayStatus { get; set; }

    public string? CourseCateDesc { get; set; }

    public string? ImageLink { get; set; }

    public string? HeadCategoryId { get; set; }

    public string? SubHeadCategoryId { get; set; }

    public virtual ICollection<AlisonAllCourse712> AlisonAllCourse712s { get; set; } = new List<AlisonAllCourse712>();

    public virtual ICollection<AlisonAllCourseOld> AlisonAllCourseOlds { get; set; } = new List<AlisonAllCourseOld>();

    public virtual ICollection<AlisonAllCourse> AlisonAllCourses { get; set; } = new List<AlisonAllCourse>();

    public virtual ICollection<AlisonSubCategory> AlisonSubCategories { get; set; } = new List<AlisonSubCategory>();
}
