using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CountryMaster
{
    public int CountryId { get; set; }

    public string? CountryName { get; set; }

    public string? CountryCode { get; set; }
}
