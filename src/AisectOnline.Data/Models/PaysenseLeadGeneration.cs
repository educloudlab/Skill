using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class PaysenseLeadGeneration
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? CustomerName { get; set; }

    public int? CustomerPin { get; set; }

    public string? Adhaar { get; set; }

    public string? StateName { get; set; }

    public string? DistrictName { get; set; }

    public string? BlockName { get; set; }

    public string? CityName { get; set; }

    public string? Mobile { get; set; }

    public DateTime? Dob { get; set; }

    public string? EmailId { get; set; }

    public string? Gender { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }
}
