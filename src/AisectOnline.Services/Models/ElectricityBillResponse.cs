using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ElectricityBillResponse
{
    public int ElectricityBillResponseId { get; set; }

    public int ElectricitytransId { get; set; }

    public string StatusId { get; set; } = null!;

    public string Status { get; set; } = null!;

    public string TransactionId { get; set; } = null!;

    public string Balance { get; set; } = null!;

    public DateTime ResponseTime { get; set; }
}
