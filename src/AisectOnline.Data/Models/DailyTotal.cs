using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class DailyTotal
{
    public int Id { get; set; }

    public string TransactionId { get; set; } = null!;

    public string? BankRefNo { get; set; }

    public string? TransactionMode { get; set; }

    public string? ReceiptNo { get; set; }

    public string? Ddno { get; set; }

    public string? BankName { get; set; }

    public string? BranchCode { get; set; }

    public DateTime? TransactionDate { get; set; }

    public decimal TransactionAmount { get; set; }

    public decimal CreditAmount { get; set; }

    public decimal DebitAmount { get; set; }

    public string? RechargeBy { get; set; }

    public string? Remark { get; set; }

    public int? KiosktypeId { get; set; }

    public int CustomerId { get; set; }

    public string? ServiceName { get; set; }

    public string? State { get; set; }

    public string? DistrictName { get; set; }

    public string? City { get; set; }

    public string? Kioskname { get; set; }

    public string? Kioskcode { get; set; }

    public string? RechargeDoneBy { get; set; }

    public string? TransType { get; set; }

    public string? Status { get; set; }

    public string? StudentName { get; set; }

    public string? Course { get; set; }

    public string? Session { get; set; }
}
