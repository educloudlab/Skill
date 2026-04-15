using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskExamCenter
{
    public int ExamCenterCode { get; set; }

    public int? KioskId { get; set; }

    public string? KioskCode { get; set; }
}
