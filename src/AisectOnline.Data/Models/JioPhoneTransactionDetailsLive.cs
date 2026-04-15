using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class JioPhoneTransactionDetailsLive
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? CartId { get; set; }

    public string? TransactionId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? TransactionResponseCode { get; set; }

    public string? TransactionStatus { get; set; }

    public int? CartTotal { get; set; }

    public int? VoucherCount { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdateOn { get; set; }

    public int? UpdatedBy { get; set; }
}
