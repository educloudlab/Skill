using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class RefundReversalRemark
{
    public int Rrid { get; set; }

    public string? TransactionId { get; set; }

    public DateTime RefundReversalDate { get; set; }

    public int Kioskid { get; set; }

    public int StudentId { get; set; }

    public string? UserRemarks { get; set; }

    public string? Status { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }
}
