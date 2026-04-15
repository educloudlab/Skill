using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CmsValidation
{
    public int Id { get; set; }

    public string? CustName { get; set; }

    public string? CustMob { get; set; }

    public string? Otp { get; set; }

    public int? KioskId { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CustomerId { get; set; }

    public bool? IsVerified { get; set; }

    public string? TransactionId { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
