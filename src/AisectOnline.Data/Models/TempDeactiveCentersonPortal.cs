using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class TempDeactiveCentersonPortal
{
    public string? Skpid { get; set; }

    public string? IsActive { get; set; }

    public int? Bcat { get; set; }

    public string? Cancel { get; set; }

    public int? Cancount { get; set; }

    public string? Csession { get; set; }

    public string? Cmonth { get; set; }

    public string? Canrem { get; set; }

    public DateTime? Canceldate { get; set; }

    public DateTime? Dentdt { get; set; }

    public DateTime? Expiredt { get; set; }
}
