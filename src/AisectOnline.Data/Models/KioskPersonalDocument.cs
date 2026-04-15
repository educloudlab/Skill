using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskPersonalDocument
{
    public int Sno { get; set; }

    public int? CustomerId { get; set; }

    public int? DocTypeId { get; set; }

    public string? DocPhoto { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public string? UpdatedDt { get; set; }

    public virtual KioskDocTypeMaster? DocType { get; set; }
}
