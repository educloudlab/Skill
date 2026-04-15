using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KotakEnquiry
{
    public int Id { get; set; }

    public string? Fname { get; set; }

    public string? Lname { get; set; }

    public string? MobileNo { get; set; }

    public string? Dob { get; set; }

    public string? EmailId { get; set; }

    public string? Gender { get; set; }

    public string? TobaccoUser { get; set; }

    public string? Source { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? KioskId { get; set; }
}
