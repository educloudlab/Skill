using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskprogrammeAguSgsu22072024
{
    public int KioskprogrammeId { get; set; }

    public int? Kioskid { get; set; }

    public int? KioskserviceId { get; set; }

    public int? ProgrammeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public double? Discount { get; set; }
}
