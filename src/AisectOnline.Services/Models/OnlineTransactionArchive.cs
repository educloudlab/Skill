using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class OnlineTransactionArchive
{
    public int OnlineTransactionId { get; set; }

    public int? CustomerId { get; set; }

    public int? Kioskid { get; set; }

    public int? StudentId { get; set; }

    public int? EWalletTransactionId { get; set; }

    public int? TransactionId { get; set; }

    public string? MerchantCode { get; set; }

    public string? PayReqUrl { get; set; }

    public string? PayReqMerchantRefNo { get; set; }

    public decimal? PayReqAmount { get; set; }

    public string? PayRespBankRefNo { get; set; }

    public decimal? PayRespAmount { get; set; }

    public string? PayRespMerchantRefNo { get; set; }

    public string? PayRespStatus { get; set; }

    public string? PayRespStatusDesc { get; set; }

    public string? DoubleVerReqUrl { get; set; }

    public string? DoubleVerReqBankRefNo { get; set; }

    public decimal? DoubleVerReqAmount { get; set; }

    public string? DoubleVerReqMerchantRefNo { get; set; }

    public string? DoubleVerRespBankRefNo { get; set; }

    public decimal? DoubleVerRespAmount { get; set; }

    public string? DoubleVerRespMerchantRefNo { get; set; }

    public string? DoubleVerRespStatus { get; set; }

    public string? DoubleVerRespStatusDesc { get; set; }

    public DateTime? TransactionDate { get; set; }

    public DateTime? SettlmentDate { get; set; }

    public int? CreatedBy { get; set; }

    public int? KioskserviceId { get; set; }

    public string? TransactionType { get; set; }

    public int? TransactionTypeId { get; set; }
}
