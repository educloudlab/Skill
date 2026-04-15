using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class NetMedsRegistration
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public int Kioskid { get; set; }

    public string? EmailId { get; set; }

    public DateTime? EnterDate { get; set; }
}
