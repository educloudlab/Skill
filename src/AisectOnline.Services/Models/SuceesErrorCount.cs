using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class SuceesErrorCount
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public DateOnly? CreatedOn { get; set; }

    public int? Hhour { get; set; }

    public int? SuccessCount { get; set; }

    public int? ErrorCount { get; set; }
}
