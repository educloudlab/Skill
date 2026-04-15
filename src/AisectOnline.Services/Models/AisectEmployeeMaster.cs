using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AisectEmployeeMaster
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
