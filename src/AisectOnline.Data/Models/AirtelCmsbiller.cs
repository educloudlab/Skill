using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AirtelCmsbiller
{
    public int Id { get; set; }

    public string? BillerName { get; set; }

    public string? BillerUrl { get; set; }

    public string? BillerType { get; set; }
}
