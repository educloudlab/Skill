using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Temp29
{
    public string Statename { get; set; } = null!;

    public string? Districtname { get; set; }

    public DateOnly? Date { get; set; }

    public int? TotalStudent { get; set; }

    public string Year { get; set; } = null!;
}
