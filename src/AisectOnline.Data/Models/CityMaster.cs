using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CityMaster
{
    public int CityId { get; set; }

    public string? CityName { get; set; }

    public string? IfChange { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsLock { get; set; }
}
