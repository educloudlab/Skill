using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class TblRailwayReservation
{
    public int RailId { get; set; }

    public string? Kioskcode { get; set; }

    public string? Kioskname { get; set; }

    public string? FirstName { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Address { get; set; }

    public string? Remarks { get; set; }
}
