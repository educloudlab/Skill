using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PaytmTransactionDetail
{
    public int Id { get; set; }

    public int KioskId { get; set; }

    public string? KioskCode { get; set; }

    public string OrderId { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string EmailId { get; set; } = null!;

    public decimal TxnAmount { get; set; }

    public string PayTmTransactionId { get; set; } = null!;

    public string AisecttransactionId { get; set; } = null!;

    public DateTime AisecttxnDate { get; set; }

    public string TxnStatus { get; set; } = null!;

    public string TxnMessage { get; set; } = null!;

    public string TxnResponseCode { get; set; } = null!;

    public string TxnRefundAmount { get; set; } = null!;

    public DateTime EnterDate { get; set; }
}
