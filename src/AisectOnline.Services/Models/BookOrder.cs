using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BookOrder
{
    public int OrderId { get; set; }

    public string? Transactionid { get; set; }

    public int? Customerid { get; set; }

    public int? Kioskid { get; set; }

    public int? PackageId { get; set; }

    public int? Quantity { get; set; }

    public double? Amount { get; set; }

    public string? Status { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }
}
