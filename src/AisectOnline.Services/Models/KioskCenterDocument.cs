using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskCenterDocument
{
    public int CustomerId { get; set; }

    public int? DocTypeId { get; set; }

    public string? DocPhoto { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }

    public int Sno { get; set; }

    public virtual KioskDocTypeMaster? DocType { get; set; }
}
