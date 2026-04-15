using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PassengerCancelDeatil
{
    public int RespId { get; set; }

    public int? PaasangerId { get; set; }

    public string? Success { get; set; }

    public string? IsCancellable { get; set; }

    public double? BasePrice { get; set; }

    public double? ServiceTax { get; set; }

    public double? Charges { get; set; }

    public string? RefundableRate { get; set; }

    public double? CancellationCharges { get; set; }

    public double? BaseFareRefundAmt { get; set; }

    public double? ServiceTaxRefundAmt { get; set; }

    public string? RefundableText { get; set; }

    public string? SeatName { get; set; }

    public double? Gst { get; set; }

    public string? GstOnCancellationCharge { get; set; }

    public string? Status { get; set; }

    public string? Source { get; set; }

    public int? CustomerId { get; set; }

    public string? BookingStatus { get; set; }

    public string? TicketPnr { get; set; }

    public string? BookingId { get; set; }

    public string? ResTransactionId { get; set; }
}
