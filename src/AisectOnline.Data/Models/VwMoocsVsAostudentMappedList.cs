using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class VwMoocsVsAostudentMappedList
{
    public string? RequestNo { get; set; }

    public string? StudentName { get; set; }

    public string? Firstname { get; set; }

    public string Email { get; set; } = null!;

    public string? MobileNo { get; set; }

    public string? ProgrammeName { get; set; }

    public string? CourseType { get; set; }

    public string? Medium { get; set; }

    public DateTime? CreateOn { get; set; }
}
