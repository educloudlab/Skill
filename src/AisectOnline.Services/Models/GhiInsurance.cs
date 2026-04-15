using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class GhiInsurance
{
    public int InsLeadId { get; set; }

    public string? CustomerName { get; set; }

    public string? MobileNo { get; set; }

    public string? Location { get; set; }

    public string? BranchManName { get; set; }

    public string? BranchLocation { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchManMob { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public int? InsuranceType { get; set; }
}
