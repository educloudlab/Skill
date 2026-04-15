using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceApiErrorLog2
{
    public int ApilogId { get; set; }

    public int? ServiceId { get; set; }

    public int? KioskId { get; set; }

    public int? TransactionId { get; set; }

    public string? ReqCn { get; set; }

    public string? Module { get; set; }

    public string? ErrorEvent { get; set; }

    public string? ErrorMessage { get; set; }

    public string? ErrorOrigin { get; set; }

    public string? ResString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }
}
