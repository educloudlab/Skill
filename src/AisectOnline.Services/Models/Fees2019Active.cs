using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Fees2019Active
{
    public double? IsActive { get; set; }

    public string? StateName { get; set; }

    public string? OldKioskCode { get; set; }

    public string? SkpId { get; set; }

    public string? Pid { get; set; }

    public string? NewCentreLevel { get; set; }

    public double? AisectRenewalFees20192020 { get; set; }

    public double? AllPreviousYearNotRenewFees { get; set; }

    public double? AguRenewalFees20192020 { get; set; }

    public string? CentreOwner { get; set; }

    public string? AcademyName { get; set; }

    public string? AcademicProgram { get; set; }

    public string? Own { get; set; }
}
