using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MpczRefund
{
    public int Id { get; set; }

    public string? Vleid { get; set; }

    public string? OrderId { get; set; }

    public double? Amount { get; set; }

    public string? Client { get; set; }

    public string? Token { get; set; }

    public int? VlecustomerId { get; set; }

    public int? TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? Msg { get; set; }

    public string? RequestJson { get; set; }

    public int? ServiceTxnId { get; set; }

    public int? Status { get; set; }

    public DateTime? CreatedOn { get; set; }
}
