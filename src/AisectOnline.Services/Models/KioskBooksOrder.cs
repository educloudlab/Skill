using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskBooksOrder
{
    public int Orderid { get; set; }

    public int Kioskid { get; set; }

    public int Packageid { get; set; }

    public int? Quantity { get; set; }

    public int? Status { get; set; }

    public int? Amount { get; set; }

    public DateTime? DateofPayment { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? Createdon { get; set; }
}
