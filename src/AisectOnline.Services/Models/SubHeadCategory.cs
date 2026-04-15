using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class SubHeadCategory
{
    public string SubHeadCategoryId { get; set; } = null!;

    public string? SubHeadCategoryName { get; set; }

    public string? SubHeadCategoryImage { get; set; }

    public bool? IsDisplay { get; set; }

    public string? HeadCategoryId { get; set; }

    public string? Description { get; set; }
}
