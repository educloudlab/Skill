using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class HeadCategory
{
    public string HeadCategoryId { get; set; } = null!;

    public string? Head { get; set; }

    public bool? DisplayStatus { get; set; }

    public string? HeadCateDesc { get; set; }

    public string? ImageLink { get; set; }
}
