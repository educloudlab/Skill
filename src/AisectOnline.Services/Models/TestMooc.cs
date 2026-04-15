using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class TestMooc
{
    public int CourseId { get; set; }

    public string? MainCategoryId { get; set; }

    public string? CourseName { get; set; }

    public string? SubCategoryId { get; set; }

    public string? SubSubCategory { get; set; }

    public string? Keywords { get; set; }

    public bool? ActiveStatus { get; set; }

    public string? Description { get; set; }

    public string? Image { get; set; }

    public string? Link { get; set; }

    public string? HeadCategoryId { get; set; }

    public string? SubHeadCategoryId { get; set; }

    public string? FileName { get; set; }

    public string? FilePath { get; set; }

    public string? Duration { get; set; }
}
