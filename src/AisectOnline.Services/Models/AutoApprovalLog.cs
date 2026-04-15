using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AutoApprovalLog
{
    public int Id { get; set; }

    public int? Kioskid { get; set; }

    public DateTime? CreatedOn { get; set; }
}
