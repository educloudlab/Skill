using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Tax2winReq1
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? MerchantId { get; set; }

    public string? MerchantCode { get; set; }

    public string MerchantName { get; set; } = null!;

    public string? MerchantType { get; set; }

    public string? MerchantAddress1 { get; set; }

    public string? MerchantAddress2 { get; set; }

    public string? MerchantCity { get; set; }

    public string? MerchantState { get; set; }

    public string? MerchantPincode { get; set; }

    public string? MerchantPhone1 { get; set; }

    public string? MerchantPhone2 { get; set; }

    public string MerchantEmail { get; set; } = null!;

    public string? MerchantOther1 { get; set; }

    public string? MerchantOther2 { get; set; }

    public string? MerchantOther3 { get; set; }

    public string? TransactionOther1 { get; set; }

    public string? TransactionOther2 { get; set; }

    public string? TransactionOther3 { get; set; }

    public string? ReturnUrl { get; set; }

    public string? ResponseBody { get; set; }

    public DateTime? Createdon { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
