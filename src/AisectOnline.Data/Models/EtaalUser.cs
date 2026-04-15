using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class EtaalUser
{
    public int EtaalUserId { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }
}
