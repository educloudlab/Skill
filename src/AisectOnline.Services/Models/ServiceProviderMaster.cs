using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceProviderMaster
{
    public int ServiceProviderMasterId { get; set; }

    public int? KioskserviceId { get; set; }

    public string? ServiceProviderName { get; set; }

    public string? ImagePath { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public decimal? ServiceTaxPercent { get; set; }

    public decimal? Tdspercent { get; set; }

    public int? TaxCalculationModeId { get; set; }

    public int? CommissionTypeId { get; set; }

    public bool? IsPrePaid { get; set; }

    public bool? IsPostPaid { get; set; }

    public bool? IsSpecialRecharge { get; set; }

    public virtual ICollection<CyberPlateRechargeDetail> CyberPlateRechargeDetails { get; set; } = new List<CyberPlateRechargeDetail>();

    public virtual ICollection<CyberPlateRechargeUrldetail> CyberPlateRechargeUrldetails { get; set; } = new List<CyberPlateRechargeUrldetail>();

    public virtual ICollection<InsurancePaymentMaster> InsurancePaymentMasters { get; set; } = new List<InsurancePaymentMaster>();

    public virtual KioskserviceMaster? Kioskservice { get; set; }

    public virtual ICollection<ServiceProviderCommissionDetail> ServiceProviderCommissionDetails { get; set; } = new List<ServiceProviderCommissionDetail>();

    public virtual ICollection<ServiceProviderStateSalesTax> ServiceProviderStateSalesTaxes { get; set; } = new List<ServiceProviderStateSalesTax>();

    public virtual MasterList? TaxCalculationMode { get; set; }
}
