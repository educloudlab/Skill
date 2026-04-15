using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StateMasterGr
{
    public int StateId { get; set; }

    public string? StateName { get; set; }

    public int? CityId { get; set; }

    public string? IfChange { get; set; }

    public DateTime? CreatedDate { get; set; }

    public bool? IsLock { get; set; }
}
