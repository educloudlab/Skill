using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ExamCenterMasterCopy
{
    public int ExamCenterId { get; set; }

    public int? ExamCenterCode { get; set; }

    public string? KioskCode { get; set; }

    public int? KioskId { get; set; }

    public int StateId { get; set; }

    public int? DistrictId { get; set; }

    public string? Location { get; set; }

    public string? Address { get; set; }
}
