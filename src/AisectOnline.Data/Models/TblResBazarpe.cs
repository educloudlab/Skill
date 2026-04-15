using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class TblResBazarpe
{
    public int ResId { get; set; }

    public int? Bid { get; set; }

    public string? TxnId { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerAddress { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? PinCode { get; set; }

    public string? Country { get; set; }

    public string? PhoneNo { get; set; }

    public string? Email { get; set; }

    public string? ProductName { get; set; }

    public string? ProductCatId { get; set; }

    public string? BazarPeOrderId { get; set; }

    public string? ProductId { get; set; }

    public string? Size { get; set; }

    public string? ProductCode { get; set; }

    public string? Userid { get; set; }

    public string? Type { get; set; }

    public string? CreatebyEmail { get; set; }

    public string? CreatebyUser { get; set; }

    public string? Domain { get; set; }

    public string? Gst { get; set; }

    public double? ProductPrice { get; set; }

    public int? Orderqty { get; set; }

    public int? Noofset { get; set; }

    public int? Totalqty { get; set; }

    public string? WeightInKg { get; set; }

    public int? ProductPriceWithqty { get; set; }

    public double? ShippingCharge { get; set; }

    public double? Igst { get; set; }

    public double? Totalamount { get; set; }
}
