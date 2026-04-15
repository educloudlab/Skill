using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Ledger
{
    public long? Id { get; set; }

    public string? Date { get; set; }

    public int? Kioskid { get; set; }

    public double? OpeningBalance { get; set; }

    public decimal Cr { get; set; }

    public decimal Dr { get; set; }

    public double? ClosingBalance { get; set; }
}
