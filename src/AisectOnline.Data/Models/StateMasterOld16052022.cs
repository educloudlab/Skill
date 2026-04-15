using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StateMasterOld16052022
{
    public string StateCode { get; set; } = null!;

    public string StateName { get; set; } = null!;

    public int CountryId { get; set; }

    public int StateId { get; set; }

    public decimal? Discount { get; set; }

    public int? GstStateCode { get; set; }

    public virtual ICollection<DistrictMasterOld16052022> DistrictMasterOld16052022s { get; set; } = new List<DistrictMasterOld16052022>();

    public virtual ICollection<Kioskdatum> Kioskdata { get; set; } = new List<Kioskdatum>();

    public virtual ICollection<ServiceProviderStateSalesTax> ServiceProviderStateSalesTaxes { get; set; } = new List<ServiceProviderStateSalesTax>();
}
