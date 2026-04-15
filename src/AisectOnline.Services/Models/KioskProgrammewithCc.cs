using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskProgrammewithCc
{
    public string? KioskCode { get; set; }

    public int CourseCategoryId { get; set; }

    public string? CourseCategory { get; set; }

    public string? Code { get; set; }

    public string? CordiAcademy { get; set; }

    public int? ProgrammeId { get; set; }

    public string? ProgrammeName { get; set; }
}
