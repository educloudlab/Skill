using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Ivr
{
    public string? AccountId { get; set; }

    public string? ConsumerName { get; set; }

    public double? TransactionId { get; set; }

    public double? DebitAmount { get; set; }

    public double? CreditAmount { get; set; }

    public double? WalletBalance { get; set; }

    public string? Sgst { get; set; }

    public string? Cgst { get; set; }

    public string? SgstTds { get; set; }

    public string? CgstTds { get; set; }

    public string? Tds194h { get; set; }

    public string? PotalCharges { get; set; }

    public double? PaidAmount { get; set; }
}
