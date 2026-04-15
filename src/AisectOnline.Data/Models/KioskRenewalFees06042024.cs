using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskRenewalFees06042024
{
    public int Id { get; set; }

    public string? State { get; set; }

    public string? KioskCode { get; set; }

    public string? Pid { get; set; }

    public int? Customerid { get; set; }

    public string? Academy { get; set; }

    public double? AcademyFees { get; set; }

    public double? AguFees { get; set; }

    public double? PrvAcademyFees { get; set; }

    public string? AcademyFeesYn { get; set; }

    public string? AguFeesYn { get; set; }

    public string? Year { get; set; }

    public double? AcademyFeesTotal { get; set; }

    public DateTime? AcademyUpdatedOn { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }
}
