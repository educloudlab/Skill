using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class EwtLateExamFeeRemoved
{
    public int EWalletTransactionId { get; set; }

    public int? EWalletId { get; set; }

    public int CustomerId { get; set; }

    public int? StudentId { get; set; }

    public string TransactionId { get; set; } = null!;

    public int? TransactionTypeId { get; set; }

    public string? BankRefNo { get; set; }

    public int? OnlineTransactionId { get; set; }

    public string? TransactionType { get; set; }

    public string? TransactionMode { get; set; }

    public string? ReceiptNo { get; set; }

    public string? Ddno { get; set; }

    public string? BankName { get; set; }

    public string? BranchCode { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal TransactionAmount { get; set; }

    public string? Remark { get; set; }

    public string? CustomerRemark { get; set; }

    public int? RechargeStatus { get; set; }

    public int? RechargeStatusAppRejBy { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? Kioskid { get; set; }

    public string? EShoppingRefNo { get; set; }

    public int? StudentCourseFeeId { get; set; }
}
