using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MobikwikCommissionMaster
{
    public int Id { get; set; }

    public string? OperatorId { get; set; }

    public double? Commission { get; set; }

    public int? ConnectionType { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }
}
