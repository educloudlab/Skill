using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Duration
{
    public string? ProgrammeName { get; set; }

    public string? Course { get; set; }

    public string? Session { get; set; }

    public double? DurationInMonths { get; set; }

    public double? CorrectDuration { get; set; }

    public string? University { get; set; }

    public string? Academy { get; set; }
}
