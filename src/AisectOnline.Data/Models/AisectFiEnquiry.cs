using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AisectFiEnquiry
{
    public int EnqId { get; set; }

    public string? Name { get; set; }

    public string? MobileNo { get; set; }

    public string? Whatsupno { get; set; }

    public string? Email { get; set; }

    public string? District { get; set; }

    public string? State { get; set; }

    public string? PinCode { get; set; }

    public DateTime? Createdon { get; set; }

    public string? ServiceType { get; set; }

    public string? City { get; set; }
}
