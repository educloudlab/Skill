using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskprogrammeHistory
{
    public int KioskprogrammeHistoryId { get; set; }

    public int? KioskprogrammeId { get; set; }

    public int? Kioskid { get; set; }

    public int? ServiceId { get; set; }

    public int? ProgrammeId { get; set; }

    public bool? IsAdded { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
