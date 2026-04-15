using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class IrctcwalletRefund
{
    public int Id { get; set; }

    public string RefundTransId { get; set; } = null!;

    public string RetailerId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public string? DeductTransId { get; set; }

    public string? DeductTransRefNo { get; set; }

    public string? RefundMode { get; set; }

    public double? RefundAmount { get; set; }

    public double? TotalAmount { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? Udf4 { get; set; }

    public string? Udf5 { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? ResponseRefundTransId { get; set; }

    public string? ResponseRefundTransRefNo { get; set; }

    public string? ResponseStatus { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseDesc { get; set; }

    public int? AisectTransactionId { get; set; }

    public DateTime? ResponseDateTime { get; set; }
}
