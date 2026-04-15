using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class SessionOpenRole
{
    public int SessionOpenId { get; set; }

    public int? SessionId { get; set; }

    public string? Role { get; set; }

    public virtual SessionMaster? Session { get; set; }
}
