using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BvocDiscount
{
    public double? SNo { get; set; }

    public string? NameOfCompany { get; set; }

    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public string? Skpid { get; set; }

    public double? DiscountInPercent { get; set; }

    public double? DiscountInAmount { get; set; }

    public double? AmountPaidByClient { get; set; }
}
