using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ClosingPhase2Date
{
    public int ClosingId { get; set; }

    public DateTime? FromDate { get; set; }

    public DateTime? ToDate { get; set; }

    public string? ClosingMonth { get; set; }

    public string? ClosingYear { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
