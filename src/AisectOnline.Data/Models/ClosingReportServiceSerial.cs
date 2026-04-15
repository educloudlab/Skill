using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ClosingReportServiceSerial
{
    public int Id { get; set; }

    public string? Service { get; set; }

    public int SerialNo { get; set; }
}
