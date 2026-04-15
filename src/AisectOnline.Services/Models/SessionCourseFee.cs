using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class SessionCourseFee
{
    public int SessionCourseFeeId { get; set; }

    public int SessionId { get; set; }

    public int? CourseFeeId { get; set; }

    public int? CourseId { get; set; }

    public DateOnly? RegistrationSdate { get; set; }

    public DateOnly? RegistrationEdate { get; set; }

    public int? MonthlyFeeSday { get; set; }

    public int? MonthlyFeeEday { get; set; }

    public int? Status { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public bool? IsActive { get; set; }

    public bool? IsVisible { get; set; }

    public string? Remark { get; set; }

    public virtual CourseMaster? Course { get; set; }

    public virtual CourseFee? CourseFee { get; set; }

    public virtual SessionMaster Session { get; set; } = null!;

    public virtual MasterList? StatusNavigation { get; set; }

    public virtual ICollection<StudentCourseFee> StudentCourseFees { get; set; } = new List<StudentCourseFee>();
}
