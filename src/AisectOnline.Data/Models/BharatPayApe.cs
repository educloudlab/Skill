using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BharatPayApe
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public decimal? Amount { get; set; }

    public int? TransactionId { get; set; }

    public string? InvoiceNo { get; set; }

    public DateTime? CreatedOn { get; set; }
}
