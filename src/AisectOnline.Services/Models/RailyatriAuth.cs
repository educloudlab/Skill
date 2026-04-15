using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class RailyatriAuth
{
    public int Id { get; set; }

    public string? Email { get; set; }

    public string? Password { get; set; }

    public string? Type { get; set; }
}
