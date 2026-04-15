using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class PasswordHistory
{
    public int PasswordHistoryId { get; set; }

    public int? UserId { get; set; }

    public string? OldPassword { get; set; }

    public string? NewPassword { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public string? OldTransactionPassword { get; set; }

    public string? NewTransactionPassword { get; set; }
}
