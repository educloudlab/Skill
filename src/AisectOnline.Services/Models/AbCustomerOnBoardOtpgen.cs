using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AbCustomerOnBoardOtpgen
{
    public int OnBoardingId { get; set; }

    public int? ReqVer { get; set; }

    public string? ReqFeSessionId { get; set; }

    public string? ReqChannel { get; set; }

    public string? ReqPartnerId { get; set; }

    public string? ReqAgentId { get; set; }

    public string? ReqCustomerId { get; set; }

    public string ReqReference1 { get; set; } = null!;

    public string? ReqReference2 { get; set; }

    public string? ReqReference3 { get; set; }

    public string? ReqReference4 { get; set; }

    public string? ReqReference5 { get; set; }

    public string? ReqHash { get; set; }

    public string? ReqString { get; set; }

    public string? ReqSalt { get; set; }

    public string? ReqAmount { get; set; }

    public string? ResFeSessionId { get; set; }

    public int? ResCode { get; set; }

    public string? ResErrorcode { get; set; }

    public string? ResMessageText { get; set; }

    public string? ResVerificationToken { get; set; }

    public string? ResponseString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
