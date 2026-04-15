using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class IrctcwalletDeduction
{
    public int Id { get; set; }

    public string DeductTransId { get; set; } = null!;

    public string RetailerId { get; set; } = null!;

    public string SessionId { get; set; } = null!;

    public double? TotalAmount { get; set; }

    public double? ServiceCharges { get; set; }

    public double? ServiceTax { get; set; }

    public double? OtherCharges { get; set; }

    public string? Udf1 { get; set; }

    public string? Udf2 { get; set; }

    public string? Udf3 { get; set; }

    public string? Udf4 { get; set; }

    public string? Udf5 { get; set; }

    public DateTime? RequestDateTime { get; set; }

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? ResponseDeductTransId { get; set; }

    public string? ResponseDeductTransRefNo { get; set; }

    public string? ResponseStatus { get; set; }

    public string? ResponseCode { get; set; }

    public string? ResponseDesc { get; set; }

    public int? AisectTransactionId { get; set; }

    public DateTime? ResponseDateTime { get; set; }
}
