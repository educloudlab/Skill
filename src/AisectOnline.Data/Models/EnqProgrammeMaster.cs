using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class EnqProgrammeMaster
{
    public int ProgrammeId { get; set; }

    public string? ProgrammeName { get; set; }

    public string? Duration { get; set; }

    public string? Eligibility { get; set; }

    public double? Fees { get; set; }

    public int? FacultyId { get; set; }

    public int? UniversityId { get; set; }
}
