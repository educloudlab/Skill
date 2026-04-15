using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class NiaautoLogin
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public string? Token { get; set; }

    public string? Pk { get; set; }

    public string? Checksum { get; set; }

    public string? EncKioskCode { get; set; }

    public string? EncToken { get; set; }

    public string? EncChecksum { get; set; }

    public string? AllParam { get; set; }

    public DateTime? CreatedOn { get; set; }
}
