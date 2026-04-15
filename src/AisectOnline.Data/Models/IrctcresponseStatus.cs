using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class IrctcresponseStatus
{
    public int Id { get; set; }

    public string? ResponseStatus { get; set; }

    public string? Description { get; set; }
}
