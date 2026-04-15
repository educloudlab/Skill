using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class RoleMaster
{
    public int RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime CreatedOn { get; set; }

    public int CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public int? ParentRoleId { get; set; }

    public virtual ICollection<RolesMenuAccessDetail> RolesMenuAccessDetails { get; set; } = new List<RolesMenuAccessDetail>();
}
