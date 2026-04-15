using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class TransactionStatus
{
    public int Id { get; set; }

    public string? ReqOrderId { get; set; }

    public string? ResOrderId { get; set; }

    public string? ReqClient { get; set; }

    public string? ReqToken { get; set; }

    public string? ResVleid { get; set; }

    public double? ResAmount { get; set; }

    public int? ResTransactionId { get; set; }

    public string? ResStatus { get; set; }

    public string? ResMessage { get; set; }

    public string? ReqJson { get; set; }

    public string? ResJson { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
