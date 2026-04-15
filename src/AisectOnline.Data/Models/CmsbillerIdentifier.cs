using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CmsbillerIdentifier
{
    public int Id { get; set; }

    public string? BillerName { get; set; }

    public string? Identifiers { get; set; }

    public string? BillerId { get; set; }

    public DateTime? CreatedOn { get; set; }
}
