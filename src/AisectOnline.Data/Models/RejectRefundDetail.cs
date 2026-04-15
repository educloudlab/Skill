using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class RejectRefundDetail
{
    public int CustomerId { get; set; }

    public int KioskId { get; set; }

    public int Studentid { get; set; }

    public string? Course { get; set; }

    public decimal? Amount { get; set; }
}
