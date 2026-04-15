using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ExamSessionMasterAu
{
    public int ExamSessionId { get; set; }

    public int? SessionId { get; set; }

    public DateTime? ExamSessionStartDate { get; set; }

    public DateTime? ExamSessionEndDate { get; set; }

    public int? Semester { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
