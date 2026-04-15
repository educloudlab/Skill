using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskTurnOver
{
    public int Customerid { get; set; }

    public int? T20122013 { get; set; }

    public int? T20132014 { get; set; }

    public int? T20142015 { get; set; }

    public int? T20152016 { get; set; }

    public string? CurrentYear { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }
}
