using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ServiceTaxTransactionDatum
{
    public int ServiceTaxTransactionId { get; set; }

    public decimal? ServiceTax { get; set; }

    public string? TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? StudentCoursefeeId { get; set; }

    public int? Kioskid { get; set; }

    public int? ServiceId { get; set; }

    public virtual Kioskdatum? Kiosk { get; set; }
}
