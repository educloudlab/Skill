using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class SectorMaster
{
    public int SectorId { get; set; }

    public string Sector { get; set; } = null!;

    public bool? IsActive { get; set; }
}
