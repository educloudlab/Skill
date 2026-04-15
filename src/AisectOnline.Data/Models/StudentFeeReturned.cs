using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentFeeReturned
{
    public int StudentFeeReturnedId { get; set; }

    public decimal? AmountReturned { get; set; }

    public int? StudentId { get; set; }

    public int? TransactionId { get; set; }

    public int? EWalletId { get; set; }

    public DateTime? ReturnedOn { get; set; }

    public int? ReturnedBy { get; set; }

    public int? EWalletTransactionId { get; set; }

    public int? TransactionIdDr { get; set; }

    public string? Remark { get; set; }
}
