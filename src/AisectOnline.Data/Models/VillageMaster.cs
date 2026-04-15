using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class VillageMaster
{
    public int BlockId { get; set; }

    public int VillageId { get; set; }

    public string? VillageName { get; set; }
}
