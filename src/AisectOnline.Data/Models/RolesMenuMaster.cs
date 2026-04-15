using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class RolesMenuMaster
{
    public int MenuId { get; set; }

    public string? MenuName { get; set; }

    public string? ControllerName { get; set; }

    public string? ActionName { get; set; }

    public int? MenuPid { get; set; }

    public string? DisplayName { get; set; }

    public int? MenuOrder { get; set; }

    public string? ImageName { get; set; }

    public string? ImageName2 { get; set; }

    public bool? IsActive { get; set; }

    public virtual ICollection<RolesMenuAccessDetail> RolesMenuAccessDetails { get; set; } = new List<RolesMenuAccessDetail>();
}
