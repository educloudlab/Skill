using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AirtelPaymentsMaster
{
    public int Id { get; set; }

    public int? AmountFrom { get; set; }

    public int? AmountTo { get; set; }

    public string? ChargesInclusiveoGst18 { get; set; }

    public string? Gst18 { get; set; }

    public string? Apbshare { get; set; }

    public string? TotalCommissionInclusiveofGst { get; set; }

    public string? Gstdeduction18 { get; set; }

    public string? TotalAmountforSharing { get; set; }

    public string? Cspshare { get; set; }

    public string? Aisectshare { get; set; }
}
