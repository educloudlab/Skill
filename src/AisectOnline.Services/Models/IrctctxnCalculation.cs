using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class IrctctxnCalculation
{
    public int Id { get; set; }

    public int? TransactionId { get; set; }

    public decimal? DeductAmount { get; set; }

    public decimal? HoShareAmount { get; set; }

    public decimal? TotalAmount { get; set; }

    public int? MasterListTypeId { get; set; }

    public int? KioskId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public DateTime? CreatedOn { get; set; }
}
