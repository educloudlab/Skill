using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class LateFeeMaster0205222
{
    public string? Programmename { get; set; }

    public int LateFeeId { get; set; }

    public int SessionId { get; set; }

    public int Days { get; set; }

    public decimal? LateFeeAmount { get; set; }

    public bool? IsActive { get; set; }
}
