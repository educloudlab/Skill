using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceFeeType
{
    public int ServiceFeeItypeD { get; set; }

    public int? ServiceId { get; set; }

    public int? ServiceFeeId { get; set; }

    public decimal? Fee { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual MasterList? ServiceFee { get; set; }
}
