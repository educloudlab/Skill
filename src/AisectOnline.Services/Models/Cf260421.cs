using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Cf260421
{
    public string? Name { get; set; }

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
}
