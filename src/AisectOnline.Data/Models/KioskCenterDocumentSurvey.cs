using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskCenterDocumentSurvey
{
    public int CustomerId { get; set; }

    public int? DocTypeId { get; set; }

    public string? DocPhoto { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }

    public int Sno { get; set; }
}
