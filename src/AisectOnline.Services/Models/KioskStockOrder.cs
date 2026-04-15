using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskStockOrder
{
    public int Stockid { get; set; }

    public string? Receiptno { get; set; }

    public int? Paymentmode { get; set; }

    public string? PaymentDetails { get; set; }

    public int? Contentid { get; set; }

    public int? Quantity { get; set; }

    public int? Amount { get; set; }

    public DateTime? Dateoforder { get; set; }

    public string? Orderstatus { get; set; }

    public DateTime? Dateofdelivery { get; set; }

    public int? Totalinstock { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }
}
