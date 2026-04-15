using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class IrctcsessionInitiate
{
    public int Id { get; set; }

    public string InitSessionId { get; set; } = null!;

    public string RetailerId { get; set; } = null!;

    public string RetailerIp { get; set; } = null!;

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? Udf4 { get; set; }

    public string? Udf5 { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? ResponseInitSessionId { get; set; }

    public string? ResponseInitSessionIdrefNo { get; set; }

    public string? ResponseStatus { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseDesc { get; set; }

    public DateTime? ResponseDateTime { get; set; }
}
