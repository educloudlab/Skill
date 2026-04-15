using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class DuplicateKioskCode
{
    public double? Sno { get; set; }

    public string? KioskCode { get; set; }

    public string? Status { get; set; }

    public string? KioskName { get; set; }

    public string? KioskOwner { get; set; }

    public string? KioskType { get; set; }

    public string? DistrictName { get; set; }

    public string? StateName { get; set; }

    public string? Mobile { get; set; }

    public DateTime? CreatedOn { get; set; }
}
