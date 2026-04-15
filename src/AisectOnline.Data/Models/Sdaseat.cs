using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Sdaseat
{
    public int? KioskId { get; set; }

    public int? Capacity { get; set; }

    public int? SessionId { get; set; }

    public int SdaId { get; set; }
}
