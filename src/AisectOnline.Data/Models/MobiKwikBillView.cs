using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class MobiKwikBillView
{
    public int Id { get; set; }

    public string? ReqCn { get; set; }

    public string? ReqOp { get; set; }

    public string? ReqCir { get; set; }

    public string? ResBillNumber { get; set; }

    public double? ResBillAmount { get; set; }

    public double? ResBillSurcharge { get; set; }

    public string? ResBillNetAmount { get; set; }

    public DateTime? ResBillDate { get; set; }

    public DateTime? ResDueDate { get; set; }

    public double? ResMaxBillAmount { get; set; }

    public string ResAcceptPayment { get; set; } = null!;

    public string? ResAcceptPartPay { get; set; }

    public string? ResStatusMessage { get; set; }

    public string? ResExpired { get; set; }

    public string? ErrorMsg { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
