using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class EStoreShopping
{
    public int EStoreShoppingId { get; set; }

    public int? UserId { get; set; }

    public int? CustomerId { get; set; }

    public DateTime? LogInDateTime { get; set; }

    public string? SaltValue { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }
}
