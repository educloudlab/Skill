using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskApproval
{
    public int Kioskid { get; set; }

    public int? Customerid { get; set; }

    public string? Kioskcode { get; set; }

    public string? RequestNo { get; set; }

    public string? CustomerName { get; set; }

    public string Typename { get; set; } = null!;

    public string? Kioskname { get; set; }

    public string? Address { get; set; }

    public string StateName { get; set; } = null!;

    public string? DistrictName { get; set; }

    public string? BlockName { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? Phone { get; set; }

    public string? Mobile { get; set; }

    public string? Service { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Status { get; set; }

    public string? ExistingBranchCode { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? BranchManager { get; set; }
}
