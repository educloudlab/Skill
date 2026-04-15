using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Cftd071023
{
    public int CourseFeeTypeDetailId { get; set; }

    public int? CourseFeeTypeId { get; set; }

    public int? Month { get; set; }

    public decimal? Fee { get; set; }
}
