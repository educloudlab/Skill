using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ServiceMasterClosing
{
    public int Id { get; set; }

    public string? Service { get; set; }

    public string? Type { get; set; }
}
