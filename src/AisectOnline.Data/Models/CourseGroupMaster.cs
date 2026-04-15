using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CourseGroupMaster
{
    public int CourseGroupId { get; set; }

    public string? CourseGroupName { get; set; }

    public string? CourseGroupCode { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
