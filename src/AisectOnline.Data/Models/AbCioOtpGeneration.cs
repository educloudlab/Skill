using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AbCioOtpGeneration
{
    public int Otpid { get; set; }

    public int? ReqVer { get; set; }

    public string? ReqFeSessionId { get; set; }

    public string? ReqChannel { get; set; }

    public int? ReqPartnerId { get; set; }

    public string? ReqAgentId { get; set; }

    public string? ReqCustomerId { get; set; }

    public string? ReqReference1 { get; set; }

    public int? ReqReference2 { get; set; }

    public int? ReqReference3 { get; set; }

    public string? ReqReference4 { get; set; }

    public string? ReqReference5 { get; set; }

    public string? ReqHash { get; set; }

    public string? ReqString { get; set; }

    public string? ResFeSessionId { get; set; }

    public int? ResCode { get; set; }

    public string? ResErrorCode { get; set; }

    public string? ResMessageText { get; set; }

    public string? ResVerificationToken { get; set; }

    public string? ResponseString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
