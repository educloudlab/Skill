using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class DelStudent
{
    public int Sno { get; set; }

    public int StudentId { get; set; }

    public string Requestno { get; set; } = null!;
}
