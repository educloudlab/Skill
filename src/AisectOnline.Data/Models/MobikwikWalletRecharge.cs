using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class MobikwikWalletRecharge
{
    public int Id { get; set; }

    public double? Amount { get; set; }

    public DateTime? Date { get; set; }

    public DateTime? RechargeEndDate { get; set; }

    public int? UserId { get; set; }
}
