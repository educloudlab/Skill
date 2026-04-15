using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceProviderCommissionDetail
{
    public int CommissionDetailId { get; set; }

    public int? ServiceProviderId { get; set; }

    public decimal? FromAmount { get; set; }

    public decimal? ToAmount { get; set; }

    public decimal? Commission { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public decimal? CommissionPercentage { get; set; }

    public double? AisectShare { get; set; }

    public double? TotalCommision { get; set; }

    public virtual ServiceProviderMaster? ServiceProvider { get; set; }
}
