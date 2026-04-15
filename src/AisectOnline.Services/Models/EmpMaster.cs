using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class EmpMaster
{
    public double? Id { get; set; }

    public string? Name { get; set; }

    public double? RoleId { get; set; }

    public double? UserId { get; set; }

    public string? RoleName { get; set; }

    public string? ChangeRemarks { get; set; }

    public string? F7 { get; set; }
}
