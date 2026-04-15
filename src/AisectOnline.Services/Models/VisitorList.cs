using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class VisitorList
{
    public int VisitorId { get; set; }

    public string? Ip { get; set; }

    public string? Location { get; set; }

    public string? Browser { get; set; }

    public string? Datetime { get; set; }
}
