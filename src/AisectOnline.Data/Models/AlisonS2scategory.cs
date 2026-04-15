using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AlisonS2scategory
{
    public string S2scategoryId { get; set; } = null!;

    public string? S2scategoryName { get; set; }

    public string? S2scategoryImage { get; set; }

    public string? SubCategoryId { get; set; }

    public bool? IsActive { get; set; }

    public string? S2scateDesc { get; set; }

    public string? HeadCategoryId { get; set; }

    public string? SubHeadCategoryId { get; set; }

    public string? CategoryId { get; set; }

    public virtual AlisonSubCategory? SubCategory { get; set; }
}
