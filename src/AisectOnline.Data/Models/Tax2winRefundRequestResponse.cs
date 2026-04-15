using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Tax2winRefundRequestResponse
{
    public int RefundId { get; set; }

    public string? RequestType { get; set; }

    public string? TransactionId { get; set; }

    public string? MerchantId { get; set; }

    public string? MerchantCode { get; set; }

    public string? RefundReason { get; set; }

    public string? RefundDatetime { get; set; }

    public string? Consumername { get; set; }

    public string? TransactionOther1 { get; set; }

    public string? TransactionOther2 { get; set; }

    public string? TransactionOther3 { get; set; }

    public string? Createdon { get; set; }

    public string? Createdby { get; set; }

    public string? EnString { get; set; }

    public string? TransactionStatus { get; set; }

    public string? SpRefundMessage { get; set; }

    public string? SpRefundId { get; set; }

    public string? SpTimestamp { get; set; }

    public string? Updatedon { get; set; }

    public string? Updatedby { get; set; }

    public string? SendingEcho { get; set; }

    public string? RefAisectTxnId { get; set; }

    public string? RefAisectTxnDate { get; set; }
}
