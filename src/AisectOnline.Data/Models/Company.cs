using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Company
{
    public int CompanyId { get; set; }

    public string? CompanyName { get; set; }

    public string? CompanyImage { get; set; }

    public bool? IsActive { get; set; }
}
