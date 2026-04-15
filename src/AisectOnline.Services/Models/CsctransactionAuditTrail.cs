using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CsctransactionAuditTrail
{
    public int CsctransactionAuditTrailId { get; set; }

    public int? CsctransactionId { get; set; }

    public string? Ipaddress { get; set; }

    public DateOnly? AuditDate { get; set; }

    public TimeOnly? AuditTime { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public string? SessionDetails { get; set; }

    public string? Referrer { get; set; }

    public string? Url { get; set; }

    public string? UserAgent { get; set; }

    public string? LoginId { get; set; }

    public string? Csctype { get; set; }

    public string? SoftwareName { get; set; }

    public string? SoftwareVersion { get; set; }

    public string? PaymentPath { get; set; }

    public string? ReqRespParameters { get; set; }

    public virtual Cscpayment? Csctransaction { get; set; }
}
