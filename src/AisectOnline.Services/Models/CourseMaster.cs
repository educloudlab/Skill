using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CourseMaster
{
    public int CourseId { get; set; }

    public string? Name { get; set; }

    public string? ShortName { get; set; }

    public int? Duration { get; set; }

    public int? ProgrammeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? CourseMedium { get; set; }

    public string? CourseCode { get; set; }

    public int? FullCourseDurationYear { get; set; }

    public int? Courseyear { get; set; }

    public virtual ICollection<CourseFee> CourseFees { get; set; } = new List<CourseFee>();

    public virtual ProgrammeMaster? Programme { get; set; }

    public virtual ICollection<SessionCourseFee> SessionCourseFees { get; set; } = new List<SessionCourseFee>();

    public virtual ICollection<StudentCourseFee> StudentCourseFees { get; set; } = new List<StudentCourseFee>();
}
