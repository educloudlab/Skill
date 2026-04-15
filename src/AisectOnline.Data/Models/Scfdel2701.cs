using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Scfdel2701
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
}
