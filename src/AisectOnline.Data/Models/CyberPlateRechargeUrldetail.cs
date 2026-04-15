using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CyberPlateRechargeUrldetail
{
    public int CyberPlateRechargeUrlid { get; set; }

    public int ServiceProviderMasterId { get; set; }

    public int? CyberPlatConnectionTypeId { get; set; }

    public string VerificationUrl { get; set; } = null!;

    public string? PaymentUrl { get; set; }

    public string? StatusUrl { get; set; }

    public int? VerificationAccount { get; set; }

    public int? RechargeTypeId { get; set; }

    public bool? IsActive { get; set; }

    public DateOnly? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateOnly? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public double? ServiceCharge { get; set; }

    public virtual MasterList? CyberPlatConnectionType { get; set; }

    public virtual MasterList? RechargeType { get; set; }

    public virtual ServiceProviderMaster ServiceProviderMaster { get; set; } = null!;
}
