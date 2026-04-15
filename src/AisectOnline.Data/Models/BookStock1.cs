using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BookStock1
{
    public int Stockid { get; set; }

    public int? Packageid { get; set; }

    public int? Quantity { get; set; }

    public int? QuantityRecieved { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? Receivedate { get; set; }

    public double? Amount { get; set; }

    public string? RecieptNo { get; set; }

    public int? TotalQuantity { get; set; }

    public int? Ispartial { get; set; }

    public int? Status { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }
}
