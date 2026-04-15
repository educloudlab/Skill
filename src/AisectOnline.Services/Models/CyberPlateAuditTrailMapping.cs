using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CyberPlateAuditTrailMapping
{
    public int CyberPlateAuditTrailMappingId { get; set; }

    public int? CyberPlateRechargeDetailId { get; set; }

    public int? CyberPlateRechargeAuditTrailId { get; set; }
}
