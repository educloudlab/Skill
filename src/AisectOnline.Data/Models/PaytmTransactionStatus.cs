using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class PaytmTransactionStatus
{
    public int Id { get; set; }

    public string ReqMid { get; set; } = null!;

    public string ReqOrderId { get; set; } = null!;

    public string? ReqJson { get; set; }

    public string? ResTxnId { get; set; }

    public int? ResOrderId { get; set; }

    public string? ResBankTransactionId { get; set; }

    public string? ResBankName { get; set; }

    public double? ResTxnAmount { get; set; }

    public string? ResTxnType { get; set; }

    public string? ResStatus { get; set; }

    public string? ResRespCode { get; set; }

    public string? ResRespMsg { get; set; }

    public DateTime? ResTxnDate { get; set; }

    public string? ResJson { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
