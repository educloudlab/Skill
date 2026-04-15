using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ClosingStatusPhase2
{
    public int? ClosingId { get; set; }

    public bool? ClosingSubmittedYn { get; set; }

    public DateTime? ClosingSubmittedDate { get; set; }

    public bool? Project2Yn { get; set; }

    public DateTime? Project2Date { get; set; }

    public bool? GstYn { get; set; }

    public DateTime? GstDate { get; set; }

    public bool? ChAdminYn { get; set; }

    public DateTime? ChAdminDate { get; set; }

    public bool? DownloadClosingYn { get; set; }

    public DateTime? DownloadClosingDate { get; set; }

    public bool? UnivRegYn { get; set; }

    public DateTime? UnivRegDate { get; set; }

    public bool? InsAdminYn { get; set; }

    public DateTime? InsAdminDate { get; set; }

    public bool? InsAdminDownloadYn { get; set; }

    public DateTime? InsAdminDownloadDate { get; set; }
}
