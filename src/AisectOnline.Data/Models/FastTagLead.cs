using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class FastTagLead
{
    public int Id { get; set; }

    public string? Type { get; set; }

    public string? Name { get; set; }

    public string? Contactperson { get; set; }

    public string? ContactNumber { get; set; }

    public string? NoOfVehicle { get; set; }

    public string? StateName { get; set; }

    public string? DistrictName { get; set; }

    public string? City { get; set; }

    public string? Kioskid { get; set; }

    public DateTime? CreatedOn { get; set; }
}
