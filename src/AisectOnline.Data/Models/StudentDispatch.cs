using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentDispatch
{
    public int DispatchId { get; set; }

    public int StudentId { get; set; }

    public int CourseFeeId { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? CourierName { get; set; }

    public string? DispatchNo { get; set; }

    public string? DocketNo { get; set; }

    public int? Sem { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual CourseFee CourseFee { get; set; } = null!;

    public virtual MasterList? SemNavigation { get; set; }

    public virtual ICollection<StudentDispatchItem> StudentDispatchItems { get; set; } = new List<StudentDispatchItem>();
}
