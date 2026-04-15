using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceKotak
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? CustName { get; set; }

    public string? CustMob { get; set; }

    public DateTime? CustDob { get; set; }

    public string? RefNo { get; set; }

    public string? CustEmail { get; set; }

    public DateTime? CreatedOn { get; set; }
}
