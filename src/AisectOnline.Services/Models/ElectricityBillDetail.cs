using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ElectricityBillDetail
{
    public int ElectricitytransId { get; set; }

    public string KioskCode { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public decimal Amount { get; set; }

    public string OperatorCode { get; set; } = null!;

    public string Subscriber { get; set; } = null!;

    public DateTime EnterDate { get; set; }

    public string TransactionPasword { get; set; } = null!;

    public string EWalletTransaction { get; set; } = null!;
}
