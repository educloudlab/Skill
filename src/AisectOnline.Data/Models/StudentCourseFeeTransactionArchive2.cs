using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentCourseFeeTransactionArchive2
{
    public long StudentCourseFeeTransactionId { get; set; }

    public int? StudentCourseFeeId { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal? TransactionAmount { get; set; }

    public string? BankRefNo { get; set; }

    public string? TransactionId { get; set; }

    public int? SessionId { get; set; }

    public int? EWalletId { get; set; }

    public int? OnlineTransactionId { get; set; }

    public string? TransactionMode { get; set; }

    public int? Kioskid { get; set; }

    public int? ServiceId { get; set; }

    public string? DdchequeNumber { get; set; }

    public string? BankName { get; set; }

    public int? StudentId { get; set; }

    public int? CourseId { get; set; }
}
