using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AbCustomerProfile
{
    public int ProfileId { get; set; }

    public int? ReqVer { get; set; }

    public string? ReqFeSessionId { get; set; }

    public string? ReqChannel { get; set; }

    public int? ReqPartnerId { get; set; }

    public string? ReqAgentId { get; set; }

    public int? ReqOtp { get; set; }

    public string? ReqVerificationToken { get; set; }

    public string? ReqHash { get; set; }

    public string? ReqString { get; set; }

    public string? ResFeSessionId { get; set; }

    public int? ResCode { get; set; }

    public string? ResErrorcode { get; set; }

    public string? ResMessageText { get; set; }

    public DateTime? ResResponseTimestamp { get; set; }

    public string? ResAccountType { get; set; }

    public string? ResAccountStatus { get; set; }

    public string? ResCustName { get; set; }

    public string? ResEmailId { get; set; }

    public string? ResponseString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
