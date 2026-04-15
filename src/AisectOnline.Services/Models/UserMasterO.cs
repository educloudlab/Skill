using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class UserMasterO
{
    public int UserId { get; set; }

    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public string? TransactionPassword { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public bool IsActive { get; set; }

    public bool? IsPasswordChange { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? CurrentLoginDate { get; set; }

    public DateTime? LastLoginDate { get; set; }

    public int CreatedBy { get; set; }

    public DateTime CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? AttemptNo { get; set; }

    public DateTime? AttemptDate { get; set; }

    public bool? IsBlocked { get; set; }

    public string? Token { get; set; }

    public DateTime? TokenSendDate { get; set; }

    public int? XpwdAttemptNo { get; set; }

    public DateTime? XpwdAttemptDate { get; set; }

    public bool? XpwdIsBlocked { get; set; }

    public bool? EShopAllowed { get; set; }

    public int? ActiveRoleId { get; set; }

    public string? OskioskCode { get; set; }
}
