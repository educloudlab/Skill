using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentExamIsBacklog
{
    public long Id { get; set; }

    public int? StudentCourseFeeId { get; set; }

    public int? SessionId { get; set; }

    public bool? Isbacklog { get; set; }
}
