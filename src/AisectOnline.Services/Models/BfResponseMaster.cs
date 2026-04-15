using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BfResponseMaster
{
    public long RequestId { get; set; }

    public string? PartnerId { get; set; }

    public string? Urn { get; set; }

    public decimal? BalanceAmount { get; set; }

    public string? ClientAmtDtl { get; set; }

    public string? CustName { get; set; }

    public string? CustState { get; set; }

    public string? CustCity { get; set; }

    public string? Urnstatus { get; set; }

    public string? RejectReason { get; set; }

    public string? BaflTranId { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? UrnRes { get; set; }

    public int? Kioskid { get; set; }

    public DateTime? ResponseDate { get; set; }

    public virtual ICollection<BfPaymentMaster> BfPaymentMasters { get; set; } = new List<BfPaymentMaster>();
}
