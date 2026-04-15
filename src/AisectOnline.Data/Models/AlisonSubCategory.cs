using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AlisonSubCategory
{
    public string SubCategoryId { get; set; } = null!;

    public string? SubCategoryName { get; set; }

    public string? SubCategoryImage { get; set; }

    public bool? IsDisplay { get; set; }

    public string? MainCategoryId { get; set; }

    public string? SubCateDesc { get; set; }

    public string? HeadCategoryId { get; set; }

    public string? SubHeadCategoryId { get; set; }

    public string? ProgrammeName { get; set; }

    public virtual ICollection<AlisonS2scategory> AlisonS2scategories { get; set; } = new List<AlisonS2scategory>();

    public virtual AlisonCourseCategory? MainCategory { get; set; }
}
