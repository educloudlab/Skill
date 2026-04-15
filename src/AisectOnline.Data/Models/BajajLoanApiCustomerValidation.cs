using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BajajLoanApiCustomerValidation
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public string? UniqueSessionId { get; set; }

    public string? ReqApiType { get; set; }

    public string? ReqLan { get; set; }

    public string? ReqToken { get; set; }

    public string? ReqPartnerId { get; set; }

    public string? ReqMerchantId { get; set; }

    public string? ResCustLan { get; set; }

    public string? ResCustName { get; set; }

    public decimal? ResLatePaymentCharge { get; set; }

    public decimal? ResChequeBounceCharge { get; set; }

    public DateTime? ResDueDate { get; set; }

    public decimal? ResApiNextEmiDue { get; set; }

    public string? ResApiFutureInstNo { get; set; }

    public decimal? ResApiOutsAmt { get; set; }

    public decimal? ResApiInstOverdue { get; set; }

    public decimal? ResApiOtherDue { get; set; }

    public decimal? ResApiNetReceivable { get; set; }

    public string? ResBaflTransactionId { get; set; }

    public string? ResPartnerId { get; set; }

    public string? ResMsgCode { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
