using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class RolesMenuAccessDetail
{
    public int RoleId { get; set; }

    public int MenuId { get; set; }

    public bool? AccessFlag { get; set; }

    public virtual RolesMenuMaster Menu { get; set; } = null!;

    public virtual RoleMaster Role { get; set; } = null!;
}
