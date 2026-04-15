using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class GasOrderDetail
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public int Kioskid { get; set; }

    public string? OrderId { get; set; }

    public string OperatorCode { get; set; } = null!;

    public string OperatorName { get; set; } = null!;

    public string ConsumerNo { get; set; } = null!;

    public decimal TxnAmount { get; set; }

    public string BillDate { get; set; } = null!;

    public string BillDueDate { get; set; } = null!;

    public string BillNumber { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public DateTime EnterDate { get; set; }
}
