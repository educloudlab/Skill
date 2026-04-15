using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ComplaintSubjectMaster
{
    public int Uid { get; set; }

    public int? SubId { get; set; }

    public int? DeptId { get; set; }

    public string? Subject { get; set; }

    public bool? IsLock { get; set; }

    public DateOnly? CreateDate { get; set; }

    public string? CreateBy { get; set; }

    public int? DepartmentId { get; set; }
}
