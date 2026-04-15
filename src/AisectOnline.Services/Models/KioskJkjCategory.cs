using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskJkjCategory
{
    public string? Kioskcode { get; set; }

    public string? Category { get; set; }

    public int? KioskId { get; set; }

    public int? Customerid { get; set; }
}
