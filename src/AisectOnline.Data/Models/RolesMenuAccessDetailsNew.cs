using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class RolesMenuAccessDetailsNew
{
    public int RoleId { get; set; }

    public int MenuId { get; set; }

    public bool? AccessFlag { get; set; }
}
