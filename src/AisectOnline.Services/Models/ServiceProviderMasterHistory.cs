using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceProviderMasterHistory
{
    public int ServiceProviderMasterHistoryId { get; set; }

    public int? ServiceProviderMasterId { get; set; }

    public int? KioskserviceId { get; set; }

    public string? ServiceProviderName { get; set; }

    public int? SrvcPrvidrMstrCreatedBy { get; set; }

    public DateTime? SrvcPrvderMstrCreatedOn { get; set; }

    public int? SrvcPrvderMstrUpdatedBy { get; set; }

    public DateTime? SrvcPrvderMstrUpdatedOn { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? StateId { get; set; }

    public decimal? SalesTax { get; set; }

    public decimal? ServiceTaxPercent { get; set; }

    public decimal? Tdspercent { get; set; }

    public int? TaxCalculationModeId { get; set; }

    public int? CommissionTypeId { get; set; }

    public bool? IsPrePaid { get; set; }

    public bool? IsPostPaid { get; set; }

    public bool? IsSpecialRecharge { get; set; }
}
