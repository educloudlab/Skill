using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Bazarpe
{
    public int Bid { get; set; }

    public int? Kioskid { get; set; }

    public string? Kioskcode { get; set; }

    public int? Customerid { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Pancardno { get; set; }

    public string? Aadharno { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public int? Zipno { get; set; }

    public string? Cardtype { get; set; }

    public int? Maincatid { get; set; }

    public string? Maincatname { get; set; }

    public int? Productid { get; set; }

    public string? Name { get; set; }

    public string? Shortdes { get; set; }

    public string? Description { get; set; }

    public double? Actualprice { get; set; }

    public double? Sellingprice { get; set; }

    public double? PerUnitPrice { get; set; }

    public int? Noofset { get; set; }

    public int? Minimumquantity { get; set; }

    public double? Offerprice { get; set; }

    public int? Stockquantity { get; set; }

    public string? Productcode { get; set; }

    public double? Size { get; set; }

    public double? Waight { get; set; }

    public string? Color { get; set; }

    public string? EwltxnId { get; set; }

    public string? Aisectshare { get; set; }

    public string? Branchshare { get; set; }

    public string? Thirdpartishare { get; set; }

    public double? ShippingPrice { get; set; }

    public double? Gst { get; set; }

    public string? Image { get; set; }

    public string? Image1 { get; set; }

    public string? Image2 { get; set; }

    public string? Image3 { get; set; }

    public string? Imagealt { get; set; }

    public string? Address { get; set; }

    public int? UserId { get; set; }

    public string? Domain { get; set; }

    public string? BazarpeOrderId { get; set; }

    public DateTime? Date { get; set; }

    public string? EwlltxnAmount { get; set; }

    public DateTime? EwltxnDate { get; set; }
}
