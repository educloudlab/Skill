using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class LoanLeadKioskAuthorization
{
    public int AuthId { get; set; }

    public string? KioskCode { get; set; }

    public string? ServiceName { get; set; }
}
