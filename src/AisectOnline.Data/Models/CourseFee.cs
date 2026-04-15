using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CourseFee
{
    public int CourseFeeId { get; set; }

    public int? CourseId { get; set; }

    public string? CourseFeeName { get; set; }

    public decimal? Fee { get; set; }

    public int? SchemeId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public virtual CourseMaster? Course { get; set; }

    public virtual ICollection<CourseFeeType> CourseFeeTypes { get; set; } = new List<CourseFeeType>();

    public virtual CourseSchemeMaster? Scheme { get; set; }

    public virtual ICollection<SessionCourseFee> SessionCourseFees { get; set; } = new List<SessionCourseFee>();

    public virtual ICollection<StudentDispatch> StudentDispatches { get; set; } = new List<StudentDispatch>();
}
