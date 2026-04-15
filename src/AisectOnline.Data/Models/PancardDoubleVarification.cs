using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class PancardDoubleVarification
{
    public int DoubleVarificationId { get; set; }

    public string? TrandId { get; set; }

    public string? MTrxId { get; set; }

    public decimal? Amount { get; set; }

    public int? PaymentRequestId { get; set; }
}
