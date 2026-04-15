using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ServiceUserMsg
{
    public int Id { get; set; }

    public string? ServiceName { get; set; }

    public string? UserMsg { get; set; }
}
