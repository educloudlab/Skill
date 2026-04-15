using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ElectricityBillAutoRefund
{
    public int ElectricityRefundId { get; set; }

    public int ElectricityBillResponseId { get; set; }

    public int ElectricitytransId { get; set; }

    public string KioskCode { get; set; } = null!;

    public string TransactionNo { get; set; } = null!;

    public decimal Amount { get; set; }

    public string OperatorCode { get; set; } = null!;

    public string Subscriber { get; set; } = null!;

    public DateTime EnterDate { get; set; }

    public string EWalletTransaction { get; set; } = null!;
}
