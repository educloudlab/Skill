using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class InsuranceEodMaster
{
    public int InsuranceEodMasterId { get; set; }

    public DateTime? FileSendOn { get; set; }

    public string? MerchantName { get; set; }

    public string? MerchantId { get; set; }

    public string? PaymentReportVoucher { get; set; }

    public string? Pvnumber { get; set; }

    public decimal? NetCredit { get; set; }
}
