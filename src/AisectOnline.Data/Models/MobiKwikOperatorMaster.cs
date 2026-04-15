using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class MobiKwikOperatorMaster
{
    public int Id { get; set; }

    public int? OperatorId { get; set; }

    public string? OperatorName { get; set; }

    public string? Category { get; set; }

    public double? Commission { get; set; }

    public string? Type { get; set; }

    public double? MinTransactionAmount { get; set; }

    public int? IsActive { get; set; }
}
