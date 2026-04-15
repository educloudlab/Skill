using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskCommissionMaster
{
    public int Sno { get; set; }

    public string? ServiceName { get; set; }

    public string? Company { get; set; }

    public string? Type { get; set; }

    public double? CommissionFromAggregator { get; set; }

    public double? CommissionFromCustomer { get; set; }

    public double? AisectShare { get; set; }

    public double? BranchShare { get; set; }

    public double? TotalCommission { get; set; }
}
