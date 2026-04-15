using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PassangerInfo
{
    public int Piid { get; set; }

    public string? Sidd { get; set; }

    public string? SourceCity { get; set; }

    public string? DestinationCity { get; set; }

    public DateTime? Date { get; set; }

    public string? Boarding { get; set; }

    public string? Dropping { get; set; }

    public string? Seat { get; set; }

    public double? BusFare { get; set; }

    public double? Discount { get; set; }

    public double? Total { get; set; }

    public string? Email { get; set; }

    public string? MobileNo { get; set; }

    public int? Transactionid { get; set; }

    public string? Searchrequest { get; set; }

    public string? SearchResponse { get; set; }

    public int? PickupId { get; set; }

    public int? DropoffId { get; set; }

    public int? SourceId { get; set; }

    public int? DestinationId { get; set; }

    public string? WalletTxnStatus { get; set; }

    public string? WalletTxnMessage { get; set; }

    public string? WalletResponseOrderId { get; set; }

    public double? WalletResponseAmount { get; set; }

    public string? WalletResponseJson { get; set; }

    public string? WalletVleidresponse { get; set; }

    public string? WalletConfirmResponse { get; set; }

    public string? BookingConfirmRequest { get; set; }

    public string? BookingConfirmResponse { get; set; }

    public string? TicketPnr { get; set; }

    public string? BookingStatus { get; set; }

    public string? BookingId { get; set; }

    public string? Cofirmmessage { get; set; }

    public string? GdsBookingId { get; set; }
}
