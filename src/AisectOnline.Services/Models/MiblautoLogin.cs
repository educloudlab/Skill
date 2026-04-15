using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MiblautoLogin
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public string? LoginId { get; set; }

    public string? Token { get; set; }

    public string? AllParam { get; set; }

    public DateTime? CreatedOn { get; set; }
}
