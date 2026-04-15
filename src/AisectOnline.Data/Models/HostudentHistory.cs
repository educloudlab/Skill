using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class HostudentHistory
{
    public int HostudentHistoryId { get; set; }

    public int StudentId { get; set; }

    public int Hokioskid { get; set; }

    public int KioskassignedBy { get; set; }

    public DateTime KioskassignedOn { get; set; }

    public string? Remark { get; set; }
}
