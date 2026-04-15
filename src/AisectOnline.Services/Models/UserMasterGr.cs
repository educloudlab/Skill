using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class UserMasterGr
{
    public int? UserId { get; set; }

    public string? UserName { get; set; }

    public string UserCode { get; set; } = null!;

    public string? UserPwd { get; set; }

    public string? OldPwd { get; set; }

    public string? AddBy { get; set; }

    public DateTime? AddDate { get; set; }

    public string? UpdBy { get; set; }

    public DateTime? UpdDate { get; set; }

    public bool? IsLocked { get; set; }

    public string? Catg { get; set; }

    public int? RoleId { get; set; }
}
