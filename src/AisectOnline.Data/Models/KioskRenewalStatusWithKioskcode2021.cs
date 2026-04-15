using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskRenewalStatusWithKioskcode2021
{
    public int Customerid { get; set; }

    public string Kioskcode { get; set; } = null!;

    public int? Year { get; set; }

    public int? AgreementSubmit { get; set; }

    public string? AmountPaid { get; set; }

    public string? PaymentMode { get; set; }

    public string? DdrecieptNo { get; set; }

    public string? Paymentdt { get; set; }

    public string? Remarks { get; set; }

    public int? Status { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? Createdt { get; set; }
}
