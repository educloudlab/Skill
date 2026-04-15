using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class MultiServiceMail
{
    public int? CustomerId { get; set; }

    public string? Kioskcode { get; set; }

    public string? Kioskname { get; set; }

    public string? BranchManager { get; set; }

    public string? Address { get; set; }

    public string? District { get; set; }

    public string State { get; set; } = null!;

    public string? Mobile { get; set; }

    public string? Phone { get; set; }

    public string? Email { get; set; }

    public string? AgreeYn { get; set; }

    public DateTime? CreatedOn { get; set; }
}
