using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class RailwayEnquiryForm
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? EmailId { get; set; }

    public string? District { get; set; }

    public string? State { get; set; }

    public string? KioskId { get; set; }

    public string? MobileNo { get; set; }
}
