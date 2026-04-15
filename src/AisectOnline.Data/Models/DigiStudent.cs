using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class DigiStudent
{
    public int StudentId { get; set; }

    public string? AadharNo { get; set; }

    public string? Name { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Identifier { get; set; }

    public string? FileName { get; set; }
}
