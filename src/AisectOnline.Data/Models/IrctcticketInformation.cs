using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class IrctcticketInformation
{
    public int Id { get; set; }

    public string TicketInfoId { get; set; } = null!;

    public string RetailerId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string DeductTransId { get; set; } = null!;

    public string? DeductTransRefNo { get; set; }

    public string? TrainNumber { get; set; }

    public string? TrainName { get; set; }

    public string? JourneyFrom { get; set; }

    public string? JourneyTo { get; set; }

    public string? JourneyDate { get; set; }

    public string? PnrNo { get; set; }

    public string? Quota { get; set; }

    public string? ClassCode { get; set; }

    public string? NoOfSeats { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? Udf4 { get; set; }

    public string? Udf5 { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? ResponseTicketInfoId { get; set; }

    public string? ResponseTicketInfoRefNo { get; set; }

    public string? ResponseStatus { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseDesc { get; set; }

    public DateTime? ResponseDateTime { get; set; }
}
