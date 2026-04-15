using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ElectricityOperator
{
    public int OperatorId { get; set; }

    public string OperatorCode { get; set; } = null!;

    public string OperatorName { get; set; } = null!;

    public int? IsActive { get; set; }
}
