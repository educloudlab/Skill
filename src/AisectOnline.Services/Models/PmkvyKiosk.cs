using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PmkvyKiosk
{
    public long? Sno { get; set; }

    public int CenterId { get; set; }

    public string? RequestNo { get; set; }

    public string BrActivationStatus { get; set; } = null!;

    public string? BranchCode { get; set; }

    public string? BrPartenerName { get; set; }

    public string? PoliceRegNo { get; set; }

    public string? BrCenterName { get; set; }

    public string RenewalStatus { get; set; } = null!;

    public string? BrLocationCity { get; set; }

    public string? BrState { get; set; }

    public DateTime? AgreementDate { get; set; }

    public string? Kiosktype { get; set; }

    public string? BrMobile { get; set; }

    public string? BrPhone { get; set; }

    public string? BrFax { get; set; }

    public string? BrPinCode { get; set; }

    public string? BrEmailId { get; set; }

    public string? BranchManager { get; set; }

    public DateTime? ActivationDate { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? Kioskservices { get; set; }

    public string? ExistingBranchCode { get; set; }

    public string? LoginId { get; set; }

    public string? BrDistrict { get; set; }

    public string? BrAddress { get; set; }

    public string? AdminRemark { get; set; }

    public string? FadminRemark { get; set; }
}
