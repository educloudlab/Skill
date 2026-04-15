using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ActivityLogUser
{
    public int LogId { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public DateTime? LoginDateTime { get; set; }

    public DateTime? LogoutDateTime { get; set; }

    public DateTime? MpczredirectTime { get; set; }
}
