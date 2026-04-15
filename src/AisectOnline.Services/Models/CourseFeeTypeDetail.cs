using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CourseFeeTypeDetail
{
    public int CourseFeeTypeDetailId { get; set; }

    public int? CourseFeeTypeId { get; set; }

    public int? Month { get; set; }

    public decimal? Fee { get; set; }

    public virtual CourseFeeType? CourseFeeType { get; set; }
}
