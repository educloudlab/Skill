using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PrintGroupCount
{
    public int Id { get; set; }

    public int? StartCount { get; set; }

    public int? EndCount { get; set; }
}
