using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class TableAudit
{
    public int TableAuditId { get; set; }

    public string? TableName { get; set; }

    public string? TableAlias { get; set; }

    public string? ColumnName { get; set; }

    public string? OldValue { get; set; }

    public string? NewValue { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
