using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PassangerDeatial
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? Age { get; set; }

    public string? Gender { get; set; }

    public int? Pid { get; set; }

    public string? SeatNo { get; set; }

    public int? CustomerId { get; set; }
}
