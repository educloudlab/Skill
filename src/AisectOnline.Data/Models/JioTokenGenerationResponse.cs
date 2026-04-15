using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class JioTokenGenerationResponse
{
    public int TokenId { get; set; }

    public string? AccessToken { get; set; }

    public string? TokenType { get; set; }

    public string? ExpiresIn { get; set; }

    public string? RefreshToken { get; set; }

    public string? Scope { get; set; }

    public string? AgentCode { get; set; }

    public string? AadhaarId { get; set; }

    public string? UserName { get; set; }

    public string? DisplayName { get; set; }

    public string? Role { get; set; }

    public string? AreaOffice { get; set; }

    public string? FunctionalManagerId { get; set; }

    public string? LineManagerId { get; set; }

    public string? ParentCompany { get; set; }

    public string? Rjildepartment { get; set; }

    public string? Org { get; set; }

    public string? Orgname { get; set; }

    public string? DistributionCenter { get; set; }

    public string? Orgcity { get; set; }

    public string? Orgstate { get; set; }

    public string? Orgcircle { get; set; }

    public string? OrgEmail { get; set; }

    public string? OrgphoneNumber { get; set; }

    public string? Orggroup { get; set; }

    public string? Createdby { get; set; }

    public string? KioskId { get; set; }

    public DateTime? Createdon { get; set; }

    public string? TokenState { get; set; }

    public string? TokenScope { get; set; }

    public string? SecretKey { get; set; }

    public string? GrantType { get; set; }

    public string? ApiKey { get; set; }

    public string? Password { get; set; }

    public string? UserNameheader { get; set; }

    public DateTime? Updateon { get; set; }

    public int? UpdatedBy { get; set; }
}
