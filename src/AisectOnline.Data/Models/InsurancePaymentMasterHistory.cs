using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class InsurancePaymentMasterHistory
{
    public int InsurancePaymentMasterHistoryId { get; set; }

    public int? InsurancePaymentMasterId { get; set; }

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

    public int? FirstReqAuditTrailId { get; set; }

    public int? FirstResAuditTrailId { get; set; }

    public DateTime? InsurancePaymentMasterUpdatedOn { get; set; }

    public DateTime? InsurancePaymentMasterUpdatedBy { get; set; }

    public DateTime? InsurancePaymentMasterCreatedBy { get; set; }

    public DateTime? InsurancePaymentMasterCreatedOn { get; set; }

    public string? EmailId { get; set; }
}
