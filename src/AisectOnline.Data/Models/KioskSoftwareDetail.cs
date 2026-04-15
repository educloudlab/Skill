using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskSoftwareDetail
{
    public int Customerid { get; set; }

    public string? Windows98 { get; set; }

    public string? WindowsMe { get; set; }

    public string? Windows2003 { get; set; }

    public string? Windows2007 { get; set; }

    public string? Windows8 { get; set; }

    public string? WindowsXp { get; set; }

    public string? Windows2010 { get; set; }

    public string? WindowsOther { get; set; }

    public string? OtherSoftware { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }

    public int? Windows98LicnYn { get; set; }

    public int? WindowsMeLicnYn { get; set; }

    public int? Windows2003LicnYn { get; set; }

    public int? Windows2007LicnYn { get; set; }

    public int? Windows8LicnYn { get; set; }

    public int? WindowsXpLicnYn { get; set; }

    public int? Windows2010LicnYn { get; set; }

    public int? WindowsOtherLicnYn { get; set; }

    public int? OtherSoftwareLicnYn { get; set; }
}
