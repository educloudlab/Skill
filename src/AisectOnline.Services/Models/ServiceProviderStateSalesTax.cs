using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ServiceProviderStateSalesTax
{
    public int ServiceProviderStateSalesTaxId { get; set; }

    public int? ServiceProviderMasterId { get; set; }

    public int? StateId { get; set; }

    public decimal? SalesTax { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public virtual ServiceProviderMaster? ServiceProviderMaster { get; set; }

    public virtual StateMasterOld16052022? State { get; set; }
}
