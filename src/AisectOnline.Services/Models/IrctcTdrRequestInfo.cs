using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class IrctcTdrRequestInfo
{
    public int Id { get; set; }

    public string TdrInfotId { get; set; } = null!;

    public string RetailerId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string? TrainNumber { get; set; }

    public DateTime? JourneyDate { get; set; }

    public string? PnrNo { get; set; }

    public string? Quota { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? Udf4 { get; set; }

    public string? Udf5 { get; set; }

    public string? TdrInfotIrefNo { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? ResponseStatus { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseDesc { get; set; }

    public DateTime? ResponseDateTime { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? UpdatedBy { get; set; }
}
