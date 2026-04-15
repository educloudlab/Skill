using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskdataService09052023
{
    public int KioskdataServiceId { get; set; }

    public int? Kioskid { get; set; }

    public int? KioskserviceId { get; set; }

    public bool? IsApproved { get; set; }

    public int? AdminApproval { get; set; }

    public int? AdminApprovalBy { get; set; }

    public DateTime? AdminAppRejDate { get; set; }

    public int? FinanceApproval { get; set; }

    public int? FinanceApprovalBy { get; set; }

    public DateTime? FinanceAppRejDate { get; set; }

    public int? SadminApproval { get; set; }

    public int? SadminApprovalBy { get; set; }

    public DateTime? SadminAppRejDate { get; set; }

    public DateTime? ActiveFrom { get; set; }

    public string? AdminRemark { get; set; }

    public string? FadminRemark { get; set; }

    public string? SadminRemark { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
