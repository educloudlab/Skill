using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class NewElectricityBillResponse
{
    public int ElectricityBillResponseId { get; set; }

    public int ElectricitytransId { get; set; }

    public string? StatusId { get; set; }

    public string? Message { get; set; }

    public string? Orderid { get; set; }

    public string? Optransid { get; set; }

    public string? Partnerreqid { get; set; }

    public string? Uservar1 { get; set; }

    public string? Uservar2 { get; set; }

    public string? Uservar3 { get; set; }

    public string? Commission { get; set; }

    public string? Charge { get; set; }

    public string? Balance { get; set; }

    public DateTime? ResponseTime { get; set; }
}
