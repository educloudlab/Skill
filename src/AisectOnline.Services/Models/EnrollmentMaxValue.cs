using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class EnrollmentMaxValue
{
    public int Id { get; set; }

    public string? GroupName { get; set; }

    public long? MaxValue { get; set; }

    public int? Serviceid { get; set; }

    public string? Abbreviation { get; set; }
}
