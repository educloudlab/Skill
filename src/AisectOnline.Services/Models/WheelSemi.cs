using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class WheelSemi
{
    public int Id { get; set; }

    public int? Kioskid { get; set; }

    public string? FisrtName { get; set; }

    public string? LastName { get; set; }

    public int? Mobile { get; set; }

    public int? StateId { get; set; }

    public string? City { get; set; }

    public int? Pincode { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public string? Address { get; set; }

    public DateTime? Createdate { get; set; }
}
