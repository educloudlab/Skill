using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ErrorLog
{
    public int ErrorLogId { get; set; }

    public string? ErrorMessage { get; set; }

    public string? OperatingWithTableSpfunc { get; set; }

    public string? ErrorFromSp { get; set; }

    public DateTime? ErrorDate { get; set; }

    public string? ErrorStatement { get; set; }
}
