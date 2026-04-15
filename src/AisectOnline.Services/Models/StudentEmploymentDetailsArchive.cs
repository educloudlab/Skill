using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentEmploymentDetailsArchive
{
    public int StudentEmploymentId { get; set; }

    public int? StudentId { get; set; }

    public string? OrganizationName { get; set; }

    public int? IndustriesTypeId { get; set; }

    public string? Designation { get; set; }

    public string? Department { get; set; }

    public int? TimePeriodFromMonth { get; set; }

    public int? TimePeriodFromYear { get; set; }

    public int? TimePeriodToMonth { get; set; }

    public int? TimePeriodToYear { get; set; }

    public decimal? Ctc { get; set; }

    public bool? IsCurrent { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
