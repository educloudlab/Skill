using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class EStoreConsentForm
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public string? ConsentStatus { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? Remark { get; set; }
}
