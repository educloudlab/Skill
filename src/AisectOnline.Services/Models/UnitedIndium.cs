using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class UnitedIndium
{
    public int Id { get; set; }

    public string? Branchcode { get; set; }

    public string? Status { get; set; }

    public DateTime? Date { get; set; }

    public string? Approvel { get; set; }

    public string? Action { get; set; }

    public string? DocFileName { get; set; }

    public string? ServiceName { get; set; }

    public string? KioskId { get; set; }

    public string? DocIdName { get; set; }

    public int? TransactionId { get; set; }
}
