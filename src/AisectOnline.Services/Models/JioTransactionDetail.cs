using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class JioTransactionDetail
{
    public int Id { get; set; }

    public int KioskId { get; set; }

    public string? KioskCode { get; set; }

    public string? SourceId { get; set; }

    public string? TxnType { get; set; }

    public string? CartTotal { get; set; }

    public string? ServiceId { get; set; }

    public string? PinCode { get; set; }

    public string? BillNumber { get; set; }

    public string? SkuId { get; set; }

    public string? Amount { get; set; }

    public string? StatusCode { get; set; }

    public string? StatusReason { get; set; }

    public string? CartId { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public string? SelectedServiceCount { get; set; }

    public string SelectedVoucherCount { get; set; } = null!;

    public DateTime? TxnDate { get; set; }
}
