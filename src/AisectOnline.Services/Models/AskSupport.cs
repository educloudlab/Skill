using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AskSupport
{
    public string? Kioskcode { get; set; }

    public int UserId { get; set; }

    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public string? TransactionPassword { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public int? RoleId { get; set; }

    public string RoleName { get; set; } = null!;

    public bool IsActive { get; set; }

    public int? ParentRoleId { get; set; }

    public string IsLocked { get; set; } = null!;

    public int? AttemptNo { get; set; }
}
