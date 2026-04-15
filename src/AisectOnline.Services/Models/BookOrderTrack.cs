using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BookOrderTrack
{
    public int TrackId { get; set; }

    public int? OrderId { get; set; }

    public string? TransactionId { get; set; }

    public int? Kioskid { get; set; }

    public int? Customerid { get; set; }

    public int? PackageId { get; set; }

    public int? Quantity { get; set; }

    public int? RecQuantity { get; set; }

    public double? Amount { get; set; }

    public string? DocketId { get; set; }

    public DateTime? DocketDt { get; set; }

    public DateTime? DispatchDt { get; set; }

    public int? IsPartial { get; set; }

    public string? Status { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
