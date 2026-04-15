using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskProgramme04042023
{
    public int KioskprogrammeId { get; set; }

    public int? Kioskid { get; set; }

    public int? KioskserviceId { get; set; }

    public int? ProgrammeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public double? Discount { get; set; }
}
