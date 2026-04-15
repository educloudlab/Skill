using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MobiKwikTxnStatus
{
    public int Id { get; set; }

    public string? ReqType { get; set; }

    public string? ReqUid { get; set; }

    public string? ReqPwd { get; set; }

    public string? ReqTxnId { get; set; }

    public string? ResQryStatus { get; set; }

    public string? ResTxnId { get; set; }

    public string? ResUid { get; set; }

    public string? ResCellNo { get; set; }

    public double? ResAmount { get; set; }

    public string? ResStatus { get; set; }

    public string? ResStatusDetails { get; set; }

    public DateTime? ResDate { get; set; }

    public double? ResDisPrice { get; set; }

    public string? ResErrorMsg { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
