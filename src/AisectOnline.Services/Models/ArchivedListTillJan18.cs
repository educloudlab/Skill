using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ArchivedListTillJan18
{
    public string RequestNo { get; set; } = null!;

    public int StudentId { get; set; }

    public int StudentCourseFeeId { get; set; }

    public int StudentCourseFeeDetailId { get; set; }
}
