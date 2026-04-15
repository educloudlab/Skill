using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class EWalletTransaction
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

    /// <summary>
    /// 0= New,1=Approved,2=Rejected
    /// </summary>
    public int? RechargeStatus { get; set; }

    public int? RechargeStatusAppRejBy { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? Kioskid { get; set; }

    public string? EShoppingRefNo { get; set; }

    public int? StudentCourseFeeId { get; set; }

    public int? CitizenId { get; set; }

    public string? EncValue { get; set; }

    public string? AdminRemark { get; set; }

    public virtual EWalletMaster? EWallet { get; set; }

    public virtual ICollection<InsurancePaymentDetail> InsurancePaymentDetails { get; set; } = new List<InsurancePaymentDetail>();

    public virtual Kioskdatum? Kiosk { get; set; }

    public virtual ICollection<OnlineTransaction> OnlineTransactions { get; set; } = new List<OnlineTransaction>();

    public virtual MasterList? TransactionTypeNavigation { get; set; }
}
