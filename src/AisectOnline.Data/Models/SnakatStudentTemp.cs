using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class SnakatStudentTemp
{
    public int Sno { get; set; }

    public string? OldRegNo { get; set; }

    public string? NewRegNo { get; set; }

    public string? Name { get; set; }

    public string? FatherName { get; set; }

    public string? Course { get; set; }
}
