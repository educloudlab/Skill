using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ApierrorLog
{
    public int Id { get; set; }

    public string Message { get; set; } = null!;

    public string InnerException { get; set; } = null!;

    public string Source { get; set; } = null!;

    public string? Data { get; set; }

    public string? StackTrace { get; set; }

    public string? TargetSite { get; set; }

    public string? MachineName { get; set; }

    public DateTime? CreateOn { get; set; }
}
