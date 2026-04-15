using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskCommissionDetail
{
    public int Id { get; set; }

    public int? TransactionId { get; set; }

    public double? Amount { get; set; }

    public double? BranchShare { get; set; }

    public double? AisectShare { get; set; }

    public DateTime? TransactionDate { get; set; }

    public int? CommissionId { get; set; }
}
