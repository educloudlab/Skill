using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CoursefeeDetailsComponent
{
    public int? StudentCourseFeeId { get; set; }

    public int? SessionId { get; set; }

    public bool? IsComponentCreated { get; set; }

    public bool? ShowSelect { get; set; }

    public int? CourseFeeTypeId { get; set; }
}
