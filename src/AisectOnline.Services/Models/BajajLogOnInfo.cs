using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BajajLogOnInfo
{
    public int IndexId { get; set; }

    public int KioskId { get; set; }

    public string? PAgentName { get; set; }

    public string? PAgentCode { get; set; }

    public string? PKendraName { get; set; }

    public string? PKendraLocation { get; set; }

    public string? PSecurityCode { get; set; }

    public string? PSp { get; set; }

    public string? PChecksum { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? AllParam { get; set; }
}
