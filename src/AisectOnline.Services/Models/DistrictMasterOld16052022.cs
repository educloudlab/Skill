using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class DistrictMasterOld16052022
{
    public string? StateCode { get; set; }

    public int DistrictId { get; set; }

    public string? DistrictName { get; set; }

    public int StateId { get; set; }

    public virtual ICollection<Kioskdatum> Kioskdata { get; set; } = new List<Kioskdatum>();

    public virtual StateMasterOld16052022 State { get; set; } = null!;
}
