using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskRenewalReceipt
{
    public int ReceiptId { get; set; }

    public string? ReceiptNumber { get; set; }

    public string? ReceiptYear { get; set; }

    public string? Skpid { get; set; }

    public string? Bmname { get; set; }

    public string? StateName { get; set; }

    public string? DistrictName { get; set; }

    public string? Gstno { get; set; }

    public DateTime? PaymentDate { get; set; }

    public decimal? Amount { get; set; }

    public string? TransactionId { get; set; }

    public int? Cgst { get; set; }

    public int? Sgst { get; set; }

    public int? Igst { get; set; }

    public string? AmountToWord { get; set; }

    public int? TotalAmount { get; set; }

    public DateTime? RecpCreatedOn { get; set; }
}
