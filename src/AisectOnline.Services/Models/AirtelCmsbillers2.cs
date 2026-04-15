using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AirtelCmsbillers2
{
    public int Id { get; set; }

    public string? BillerName { get; set; }

    public string? BillerUrl { get; set; }

    public string? BillerType { get; set; }

    public DateTime? CreatedOn { get; set; }
}
