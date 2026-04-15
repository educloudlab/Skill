using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ClosingDate
{
    public int ClosingId { get; set; }

    public string? ClosingMonth { get; set; }

    public DateOnly? ClosingStartDate { get; set; }

    public DateOnly? ClosingEndDate { get; set; }
}
