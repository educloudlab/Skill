using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Complaint
{
    public int ComplaintId { get; set; }

    public string? RegistrationNo { get; set; }

    public string? KioskCode { get; set; }

    public string? EmailId { get; set; }

    public string? MobileNo { get; set; }

    public int? StatusId { get; set; }

    public string? City { get; set; }

    public int? FinalStatus { get; set; }

    public int? KioskId { get; set; }

    public int? CustomerId { get; set; }

    public int? CitizenId { get; set; }
}
