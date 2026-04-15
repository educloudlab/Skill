using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ServiceAffiliation
{
    public int AutoId { get; set; }

    public int? ServiceId { get; set; }

    public int? KioskId { get; set; }

    public int? AffiliationStatus { get; set; }

    public DateTime? ApprovalDate { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }
}
