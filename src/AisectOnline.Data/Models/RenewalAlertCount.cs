using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class RenewalAlertCount
{
    public int Sno { get; set; }

    public int? RenAgreeAlertCount { get; set; }

    public int? AgurenAlertCount { get; set; }

    public DateTime? EntryDate { get; set; }

    public int? UserId { get; set; }
}
