using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MpOpenFinalList
{
    public string? KioskCode { get; set; }

    public int KioskId { get; set; }

    public int? KioskTypeId { get; set; }

    public bool? Isactive { get; set; }
}
