using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StateMaster
{
    public string StateCode { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public int CountryId { get; set; }

    public int StateId { get; set; }

    public decimal? Discount { get; set; }

    public int? GstStateCode { get; set; }
}
