using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AuditTrail
{
    public int AuditTrailId { get; set; }

    public string? Ipaddress { get; set; }

    public DateOnly? AuditDate { get; set; }

    public TimeOnly? AuditTime { get; set; }

    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public string? SessionDetails { get; set; }

    public string? Referrer { get; set; }

    public string? ProcessId { get; set; }

    public string? Url { get; set; }

    public string? UserAgent { get; set; }

    public string? Country { get; set; }

    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public bool? IsSuccess { get; set; }

    public DateTime? LogInTime { get; set; }

    public DateTime? LogOutTime { get; set; }
}
