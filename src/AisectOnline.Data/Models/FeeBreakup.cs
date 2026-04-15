using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class FeeBreakup
{
    public int Id { get; set; }

    public int? SeviceId { get; set; }

    public int? ProgrammeId { get; set; }

    public int? CourseId { get; set; }

    public string? Medium { get; set; }

    public double? TotalFee { get; set; }

    public double? Books { get; set; }

    public double? University { get; set; }

    public double? Asm { get; set; }

    public double? Nsdc { get; set; }

    public double? Sgsu { get; set; }

    public double? AisectLearn { get; set; }

    public int? Installment { get; set; }

    public int? IsActive { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? CreatedOn { get; set; }
}
