using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class TempDataOfKiosk
{
    public string? Kioskcode { get; set; }

    public string? GenderTitle { get; set; }

    public int? GenderId { get; set; }

    public string? FirstName { get; set; }

    public string? CurrectGenderAsReport { get; set; }

    public string? CurrectGenderAsReportby { get; set; }
}
