using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ClosingRegDataLog
{
    public int Id { get; set; }

    public int? ClosingId { get; set; }

    public int? IsDownloadedCh { get; set; }

    public DateTime? DownloadedOn { get; set; }

    public int? SendToUniversityAdmin { get; set; }

    public int? IsInsAdmin { get; set; }

    public DateTime? IsInsAdminDate { get; set; }
}
