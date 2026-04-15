using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceFeePayment
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public int? Fee { get; set; }

    public int? ServiceFeeTypeId { get; set; }

    public int? TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? RenewalYear { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CustomerId { get; set; }
}
