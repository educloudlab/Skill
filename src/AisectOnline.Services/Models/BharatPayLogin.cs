using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BharatPayLogin
{
    public int Id { get; set; }

    public string? SecretId { get; set; }

    public string? ClientId { get; set; }

    public string? VleId { get; set; }

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public DateTime? ResponseDateTime { get; set; }

    public string? ResponseStatus { get; set; }

    public string? ResponseUdv { get; set; }

    public string? ResponseUdvValue { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseDesc { get; set; }
}
