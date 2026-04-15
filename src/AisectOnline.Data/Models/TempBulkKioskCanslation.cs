using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class TempBulkKioskCanslation
{
    public string? Skpid { get; set; }

    public int? Isactive { get; set; }

    public string? Bcat { get; set; }

    public string? Cancel { get; set; }

    public int? Cancount { get; set; }

    public string? Csession { get; set; }

    public string? Cmonth { get; set; }

    public string? Canrem { get; set; }

    public DateTime? Canceldate { get; set; }

    public DateTime? Enddate { get; set; }

    public DateTime? ExpireDate { get; set; }
}
