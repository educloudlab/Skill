using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskServiceAllottment
{
    public int Id { get; set; }

    public string? SkpId { get; set; }

    public int? ServiceId { get; set; }

    public int? IsActive { get; set; }
}
