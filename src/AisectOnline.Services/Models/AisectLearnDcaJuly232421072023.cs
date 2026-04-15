using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AisectLearnDcaJuly232421072023
{
    public string RequestNo { get; set; } = null!;

    public int StudentId { get; set; }

    public string EmailAddress { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public int? MiddleName { get; set; }

    public string LastName { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string? Department { get; set; }

    public string? Session { get; set; }

    public string ServiceName { get; set; } = null!;

    public string ContactAddress { get; set; } = null!;

    public string? Districtname { get; set; }

    public string? StateName { get; set; }

    public string? AadharNo { get; set; }
}
