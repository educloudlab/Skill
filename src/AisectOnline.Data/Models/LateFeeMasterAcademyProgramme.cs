using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class LateFeeMasterAcademyProgramme
{
    public int LateFeeApid { get; set; }

    public int? LateFeeId { get; set; }

    public int? ProgrammeId { get; set; }

    public int? CourseCategoryId { get; set; }

    public decimal? LateFeeAmount { get; set; }

    public bool? IsActive { get; set; }
}
