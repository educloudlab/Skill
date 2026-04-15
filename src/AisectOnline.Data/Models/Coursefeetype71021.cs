using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Coursefeetype71021
{
    public int CourseFeeTypeId { get; set; }

    public int? CourseFeeId { get; set; }

    public int? FeeTypeId { get; set; }

    public decimal? Fee { get; set; }

    public string? PaymentMode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? PaymentModeId { get; set; }

    public bool? IsLateFeeApply { get; set; }
}
