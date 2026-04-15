using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class EnqFormNumber
{
    public int Id { get; set; }

    public int? FormId { get; set; }

    public string? EnqFormNumber1 { get; set; }

    public int? UnivId { get; set; }

    public DateTime? CreatedOn { get; set; }
}
