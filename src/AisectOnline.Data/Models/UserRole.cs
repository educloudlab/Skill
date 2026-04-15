using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class UserRole
{
    public int? UserId { get; set; }

    public int? RoleId { get; set; }

    public int? Kioskid { get; set; }

    public bool? IsActive { get; set; }

    public int? ActiveRoleId { get; set; }

    public virtual RoleMaster? Role { get; set; }

    public virtual UserMaster? User { get; set; }
}
