using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class IrctcfileTdr
{
    public int Id { get; set; }

    public string TdrInfoId { get; set; } = null!;

    public string RetailerId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string? TrainNumber { get; set; }

    public string? JourneyDate { get; set; }

    public string? PnrNo { get; set; }

    public string? Quota { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? Udf4 { get; set; }

    public string? Udf5 { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? ResponseTdrInfoId { get; set; }

    public string? TdrInfoIrefNo { get; set; }

    public string? ResponseStatus { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseDesc { get; set; }

    public DateTime? ResponseDateTime { get; set; }
}
