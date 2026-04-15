using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class JioPreBookResponse
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public int Kioskid { get; set; }

    public string? SourceId { get; set; }

    public string? TxnType { get; set; }

    public string? TxnId { get; set; }

    public string? CartTotal { get; set; }

    public string? ServiceId { get; set; }

    public int? PinCode { get; set; }

    public string? SkuId { get; set; }

    public string? Amount { get; set; }

    public int? StatusCode { get; set; }

    public string? StatusReason { get; set; }

    public string? CartId { get; set; }

    public string? SelectedServiceCount { get; set; }

    public string? SelectedVoucherCount { get; set; }

    public string? CheckSum { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }
}
