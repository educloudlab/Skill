using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Ren2
{
    public string? KioskCode { get; set; }

    public double? RenewalYear { get; set; }

    public double? RenewalCharge { get; set; }

    public double? RenewalDeposit { get; set; }

    public double? ServiceTax { get; set; }

    public string? RenewalYN2021 { get; set; }

    public string? RenewalFeesYN { get; set; }

    public string? RenewalAgreementYN { get; set; }

    public double? AisectRenewalVno { get; set; }

    public string? AguRenewal { get; set; }

    public double? AguCharge { get; set; }

    public double? AguDeposit { get; set; }

    public double? AguServiceTax { get; set; }

    public double? AguVNo { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ExpiredOn { get; set; }

    public string? CreatedOn1 { get; set; }
}
