using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StatusMaster
{
    public int? Uid { get; set; }

    public int? StatusId { get; set; }

    public string? Status { get; set; }

    public string? StatusType { get; set; }

    public bool? IsLock { get; set; }

    public DateOnly? CreateDate { get; set; }
}
