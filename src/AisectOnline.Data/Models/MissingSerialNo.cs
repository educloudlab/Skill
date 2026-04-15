using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class MissingSerialNo
{
    public long? Sequence { get; set; }

    public int SesionId { get; set; }

    public string? RequestNo { get; set; }
}
