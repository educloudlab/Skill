using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class UpAuthWoonlineCa
{
    public int LogId { get; set; }

    public string? Skpid { get; set; }

    public string? AuthToken { get; set; }

    public int? ServiceId { get; set; }

    public DateTime? CreatedOn { get; set; }
}
