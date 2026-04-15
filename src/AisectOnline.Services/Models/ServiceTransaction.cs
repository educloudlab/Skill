using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceTransaction
{
    public int ServiceTransactionId { get; set; }

    public string? Vleid { get; set; }

    public string? OrderId { get; set; }

    public string? Client { get; set; }

    public int? RequestAmount { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? ResponseOrderId { get; set; }

    public string? ResponseAmount { get; set; }

    public string? TxnStatusResponse { get; set; }

    public string? TxnIdResponse { get; set; }

    public string? Vleidresponse { get; set; }

    public DateTime? TransactionnDateResponse { get; set; }

    public string? TxnMessageResponse { get; set; }

    public string? UserId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public string? TransactionType { get; set; }

    public int? Kioskid { get; set; }

    public int? Customerid { get; set; }

    public int? VlecustomerId { get; set; }
}
