using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Mobikwiktemp
{
    public int SrNo { get; set; }

    public string? NatureOfService { get; set; }

    public string ServiceProviderName { get; set; } = null!;

    public DateTime? DateOfTransaction { get; set; }

    public double? AmountCollectedOnBehalfOfServiceProvider { get; set; }

    public double? AdjustmentOfCommission { get; set; }

    public double? TotalVirtualBalanceUtilized { get; set; }
}
