using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class NetMedsOrderDetail
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public int Kioskid { get; set; }

    public string? OrderId { get; set; }

    public string? OperatorCode { get; set; }

    public string? OperatorName { get; set; }

    public string? ConsumerNo { get; set; }

    public decimal? TxnAmount { get; set; }

    public string? MobileNo { get; set; }

    public string? TokenKey { get; set; }

    public string? EmailId { get; set; }

    public DateTime? EnterDate { get; set; }
}
