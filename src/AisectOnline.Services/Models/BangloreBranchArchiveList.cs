using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BangloreBranchArchiveList
{
    public int Status { get; set; }

    public string? KioskCode { get; set; }

    public int Studentid { get; set; }

    public string Requestno { get; set; } = null!;
}
