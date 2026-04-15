using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskDiscount
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? Course { get; set; }

    public double? Discount { get; set; }
}
