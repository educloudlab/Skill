using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Cscpayment
{
    public int TransId { get; set; }

    public int? KioskId { get; set; }

    public int? StudentId { get; set; }

    public string? StudentName { get; set; }

    public double? PayableAmount { get; set; }

    public string? MerchantId { get; set; }

    public string? Ipaddress { get; set; }

    public string? VleId { get; set; }

    public string? CourseName { get; set; }

    public string? Fvurl { get; set; }

    public string? PayResPOxitrxid { get; set; }

    public string? PayResPMsg { get; set; }

    public string? PayResPMtrxid { get; set; }

    public int? PayResPTrxStatus { get; set; }

    public string? PayResPTrxMsg { get; set; }

    public string? DblVerReqUrl { get; set; }

    public string? DblVerReqTransDate { get; set; }

    public string? DblVerReqMid { get; set; }

    public string? DblVerReqEncData { get; set; }

    public string? DblVerRepMtrxId { get; set; }

    public string? DblVerRepOxitrxId { get; set; }

    public int? DblVerRepTrxStatus { get; set; }

    public string? DblVerRepTrxMsg { get; set; }

    public double? DblVerRepPaidamt { get; set; }

    public virtual ICollection<CsctransactionAuditTrail> CsctransactionAuditTrails { get; set; } = new List<CsctransactionAuditTrail>();
}
