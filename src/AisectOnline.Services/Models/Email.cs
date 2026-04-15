using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Email
{
    public string? KioskCode { get; set; }

    public string? Emailid { get; set; }

    public int? Customerid { get; set; }
}
