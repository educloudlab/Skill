using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class LeadCompanyMaster
{
    public int ColumnId { get; set; }

    public int? CompanyId { get; set; }

    public string? CompanyName { get; set; }
}
