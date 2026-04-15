using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ClosingInsuranceDatum
{
    public int Id { get; set; }

    public int? ClosingId { get; set; }

    public string? ServiceName { get; set; }

    public string? PolicyNumber { get; set; }

    public string? PolicyDocument { get; set; }

    public DateTime? CreatedOn { get; set; }
}
