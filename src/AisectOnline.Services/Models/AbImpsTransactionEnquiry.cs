using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AbImpsTransactionEnquiry
{
    public int ImpsEnqId { get; set; }

    public int? KioskId { get; set; }

    public string? ReqVer { get; set; }

    public string? ReqFessionId { get; set; }

    public string? ReqChannel { get; set; }

    public string? ReqPartnerId { get; set; }

    public string? ReqExternalRefNo { get; set; }

    public string? ReqReqestString { get; set; }

    public string? ReqHash { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? ResFessionId { get; set; }

    public string? ResCode { get; set; }

    public string? ResErrorCode { get; set; }

    public string? ResMessageText { get; set; }

    public string? ResResponseTimeStamp { get; set; }

    public string? ResExternalRefNo { get; set; }

    public string? ResTransactionId { get; set; }

    public string? ResRrn { get; set; }

    public string? ResAmount { get; set; }

    public string? ResCharge { get; set; }

    public string? ResResponseString { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
