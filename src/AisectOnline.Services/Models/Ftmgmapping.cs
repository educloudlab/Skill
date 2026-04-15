using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Ftmgmapping
{
    public int FtmgmappingId { get; set; }

    public int? FtmgroupId { get; set; }

    public string? Ftmgname { get; set; }
}
