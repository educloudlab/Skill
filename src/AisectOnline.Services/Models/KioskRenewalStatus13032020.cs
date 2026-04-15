using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskRenewalStatus13032020
{
    public int Customerid { get; set; }

    public string? Kioskcode { get; set; }

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
