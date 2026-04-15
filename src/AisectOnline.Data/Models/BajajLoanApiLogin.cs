using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BajajLoanApiLogin
{
    public int Id { get; set; }

    public string? OrderId { get; set; }

    public string? KioskCode { get; set; }

    public string? UniqueSessionId { get; set; }

    public string? ReqPartnerId { get; set; }

    public string? ReqMerchantId { get; set; }

    public string? ReqVendorUserName { get; set; }

    public string? ReqVendorPassword { get; set; }

    public string? ReqAuthKey { get; set; }

    public string? ResFlag { get; set; }

    public string? ResToken { get; set; }

    public string? ResMsgCode { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
