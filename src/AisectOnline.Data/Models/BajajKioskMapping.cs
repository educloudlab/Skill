using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BajajKioskMapping
{
    public int Id { get; set; }

    public string KioskCode { get; set; } = null!;

    public string? BajajUserCode { get; set; }
}
