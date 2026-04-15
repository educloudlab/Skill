using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Mobikwik
{
    public double? SNo { get; set; }

    public string? OperatorName { get; set; }

    public double? OperatorId { get; set; }

    public string? Category { get; set; }

    public double? Commission { get; set; }

    public string? Type { get; set; }

    public double? MinTxnValue { get; set; }

    public bool Bbps { get; set; }
}
