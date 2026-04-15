using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class WalletRechargeDetailsDatum
{
    public int WalletId { get; set; }

    public int? SessionId { get; set; }

    public int? CourseId { get; set; }

    public int? Kioskid { get; set; }

    public int? NoOfStudent { get; set; }

    public double? AuCvru { get; set; }

    public double? Asm { get; set; }

    public double? AisectLtd { get; set; }

    public double? Total { get; set; }

    public DateTime? CreatedOn { get; set; }
}
