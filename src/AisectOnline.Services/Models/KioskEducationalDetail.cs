using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskEducationalDetail
{
    public int Customerid { get; set; }

    public string? OtherItcenter { get; set; }

    public string? OtherItImageTool { get; set; }

    public string? OtherItDesc { get; set; }

    public int? SchoolId { get; set; }

    public string? CoachingCenter { get; set; }

    public string? CoachingCenterDescription { get; set; }

    public string? OtherTraining { get; set; }

    public string? OtherTrainingDescription { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }
}
