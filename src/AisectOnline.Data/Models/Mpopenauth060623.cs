using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Mpopenauth060623
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public bool? OskioskCode { get; set; }

    public bool? Osaffiliated { get; set; }

    public bool? Osrenewed { get; set; }

    public DateTime? OsrenewalExpiry { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CustomerId { get; set; }
}
