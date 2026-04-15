using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class PaytmOrderDetail
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public string? OrderId { get; set; }

    public int? Kioskid { get; set; }

    public string MobileNo { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public decimal TxnAmount { get; set; }

    public DateTime EnterDate { get; set; }
}
