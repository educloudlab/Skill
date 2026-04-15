using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentFeeCsvtemp
{
    public string? RequestNo { get; set; }

    public double? StudentId { get; set; }

    public string? Status { get; set; }

    public string? StatusOn070224 { get; set; }

    public string? CurrentStatus { get; set; }

    public bool Chk { get; set; }
}
