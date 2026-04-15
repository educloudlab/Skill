using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BookStockPartial
{
    public int StockPartialid { get; set; }

    public int StockId { get; set; }

    public int? Packageid { get; set; }

    public int? Quantity { get; set; }

    public int? QuantityRecieved { get; set; }

    public DateTime? OrderDate { get; set; }

    public DateTime? Receivedate { get; set; }

    public double? Amount { get; set; }

    public string? RecieptNo { get; set; }

    public int? TotalQuantity { get; set; }

    public string? DocketId { get; set; }

    public DateTime? DocketDt { get; set; }

    public DateTime? DispatchDt { get; set; }

    public int? Status { get; set; }

    public string? Createdby { get; set; }

    public DateTime? CreatedOn { get; set; }
}
