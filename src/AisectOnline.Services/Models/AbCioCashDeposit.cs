using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AbCioCashDeposit
{
    public int DepositId { get; set; }

    public int? ReqVer { get; set; }

    public string? ReqFeSessionId { get; set; }

    public string? ReqChannel { get; set; }

    public int? ReqPartnerId { get; set; }

    public string? ReqAgentId { get; set; }

    public int? ReqOtp { get; set; }

    public int? ReqExternalRefNo { get; set; }

    public string? ReqVerificationToken { get; set; }

    public string? ReqHash { get; set; }

    public string? ReqString { get; set; }

    public string? ResFeSessionId { get; set; }

    public int? ResCode { get; set; }

    public string? ResErrorCode { get; set; }

    public string? ResMessageText { get; set; }

    public DateOnly? ResResponseTimestamp { get; set; }

    public int? ResExternalRefNo { get; set; }

    public int? ResTranId { get; set; }

    public string? ResponseString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
