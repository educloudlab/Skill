using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class NsqfidCard
{
    public int Sno { get; set; }

    public string? Name { get; set; }

    public string? Designation { get; set; }

    public string? Trade { get; set; }

    public string? Contact { get; set; }

    public string? Location { get; set; }

    public DateTime? Validity { get; set; }

    public string? Images { get; set; }

    public int? IdentityId { get; set; }
}
