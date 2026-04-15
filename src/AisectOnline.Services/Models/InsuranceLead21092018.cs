using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class InsuranceLead21092018
{
    public int InsLeadId { get; set; }

    public string? CustomerName { get; set; }

    public string? MobileNo { get; set; }

    public string? LandlineNo { get; set; }

    public string? PostalAddress { get; set; }

    public int? CompanyName { get; set; }

    public string? BranchManName { get; set; }

    public string? BranchLocation { get; set; }

    public string? BranchCode { get; set; }

    public string? BranchManMob { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
