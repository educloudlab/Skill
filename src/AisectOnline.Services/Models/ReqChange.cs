using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ReqChange
{
    public string? Kioskcode { get; set; }

    public string? Course { get; set; }

    public string? Incorrect { get; set; }

    public string? Correct { get; set; }
}
