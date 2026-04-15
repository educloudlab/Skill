using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskConnectivity
{
    public int? Customerid { get; set; }

    public string? Fwt { get; set; }

    public string? Cdma { get; set; }

    public string? Wll { get; set; }

    public string? BroadBand { get; set; }

    public string? MobileInternet { get; set; }

    public string? Evdo { get; set; }

    public string? DataCard { get; set; }

    public string? Usbmodem { get; set; }

    public string? Dialup { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }
}
