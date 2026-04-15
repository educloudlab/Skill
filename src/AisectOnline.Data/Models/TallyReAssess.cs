using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class TallyReAssess
{
    public int? Id { get; set; }

    public int? CourseId { get; set; }

    public decimal? ReAssessmentFee { get; set; }
}
