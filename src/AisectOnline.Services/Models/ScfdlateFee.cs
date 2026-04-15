using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ScfdlateFee
{
    public int? Scfid { get; set; }

    public decimal? FeeT1 { get; set; }

    public string? TransId { get; set; }

    public int? Ftid { get; set; }

    public int? StudentCoursefeeid { get; set; }

    public decimal? Fee { get; set; }

    public string? TransactionId { get; set; }

    public int? FeeTypeId { get; set; }
}
