using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CyberPlateRechargeAuditTrail
{
    public int CyberPlateRechargeAuditTrailId { get; set; }

    public int? CyberPlateRechargeDetailId { get; set; }

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

    public string? Password { get; set; }

    public string? Csctype { get; set; }

    public string? SoftwareName { get; set; }

    public string? SoftwareVersion { get; set; }

    public string? PaymentPath { get; set; }

    public string? HostServerAddress { get; set; }

    public string? KkSrvcOprtrId { get; set; }

    public string? ReqRespParameters { get; set; }

    public string? AuditTrailOfSp { get; set; }

    public int? CyberPlatePaymentStatusCheckId { get; set; }

    public int? Kioskid { get; set; }

    public virtual CyberPlateRechargeDetail? CyberPlateRechargeDetail { get; set; }
}
