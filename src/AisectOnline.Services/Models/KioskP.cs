using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskP
{
    public int Customerid { get; set; }

    public string? NameOwner { get; set; }

    public string? NameOwnerFather { get; set; }

    public int? AgeOwner { get; set; }

    public string? NameNominee { get; set; }

    public string? RelationNominee { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }

    public int Sno { get; set; }
}
