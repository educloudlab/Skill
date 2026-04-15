using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MoocsMapping
{
    public int Mmid { get; set; }

    public string? AiprogName { get; set; }

    public string? CourseCategory { get; set; }

    public string? ServiceName { get; set; }

    public double? AiprogId { get; set; }

    public double? MoocsprogId { get; set; }

    public string? MoocsprogName { get; set; }

    public string? CourseLinkMoocs { get; set; }

    public string? Medium { get; set; }

    public string? F9 { get; set; }
}
