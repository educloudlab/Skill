using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Ewt
{
    public int EWalletTransactionId { get; set; }

    public int? TransactionId { get; set; }

    public int? StudentId { get; set; }

    public string? TransactionType { get; set; }

    public decimal? TransactionAmount { get; set; }

    public string? BankRefNo { get; set; }

    public string? TransactionMode { get; set; }

    public string? ReceiptNo { get; set; }

    public string? Ddno { get; set; }

    public string? BankName { get; set; }

    public string? BranchCode { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? Remark { get; set; }

    public int? CustomerId { get; set; }

    public int? CreatedBy { get; set; }

    public int? KioskId { get; set; }

    public int? TransactionTypeId { get; set; }

    public string? RechargeStatus { get; set; }
}
