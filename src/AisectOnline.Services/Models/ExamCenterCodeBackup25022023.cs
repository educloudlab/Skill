using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ExamCenterCodeBackup25022023
{
    public int ExamCenterId { get; set; }

    public int ExamCenterCode { get; set; }

    public int StateId { get; set; }

    public int? DistrictId { get; set; }

    public string? Location { get; set; }

    public string? Address { get; set; }

    public string? CourseSpecific { get; set; }
}
