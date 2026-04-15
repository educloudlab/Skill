using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class InsurancePaymentMaster
{
    public int InsurancePaymentMasterId { get; set; }

    public string? PolicyNo { get; set; }

    public DateTime? Dob { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public string? MobileNo { get; set; }

    public string? CredAccNo { get; set; }

    public int? KioskserviceId { get; set; }

    public string? KioskserviceName { get; set; }

    public int? ServiceProviderId { get; set; }

    public string? ServiceProviderName { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? FirstReqAuditTrailId { get; set; }

    public int? FirstResAuditTrailId { get; set; }

    public string? EmailId { get; set; }

    public virtual ICollection<InsurancePaymentAuditTrail> InsurancePaymentAuditTrails { get; set; } = new List<InsurancePaymentAuditTrail>();

    public virtual ICollection<InsurancePaymentDetail> InsurancePaymentDetails { get; set; } = new List<InsurancePaymentDetail>();

    public virtual KioskserviceMaster? Kioskservice { get; set; }

    public virtual ServiceProviderMaster? ServiceProvider { get; set; }
}
