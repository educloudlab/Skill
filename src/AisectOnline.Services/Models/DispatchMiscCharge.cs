using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class DispatchMiscCharge
{
    public int Dmcid { get; set; }

    public int? CourseId { get; set; }

    public string? MaterialType { get; set; }

    public decimal? Bag { get; set; }

    public decimal? Postage { get; set; }

    public decimal? Magazine { get; set; }

    public string? Course { get; set; }
}
