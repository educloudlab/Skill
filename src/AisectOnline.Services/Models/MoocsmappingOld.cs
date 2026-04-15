using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MoocsmappingOld
{
    public int MappingId { get; set; }

    public int? AiprogId { get; set; }

    public string? AiprogName { get; set; }

    public string? MoocsprogId { get; set; }

    public string? MoocsprogName { get; set; }

    public string? CourseLinkMoocs { get; set; }

    public int? Medium { get; set; }
}
