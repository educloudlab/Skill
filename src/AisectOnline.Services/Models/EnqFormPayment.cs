using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class EnqFormPayment
{
    public int Id { get; set; }

    public string? EnqFormId { get; set; }

    public int? Kioskid { get; set; }

    public double? TransactionAmount { get; set; }

    public string? TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }
}
