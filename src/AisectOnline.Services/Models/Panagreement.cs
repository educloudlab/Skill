using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Panagreement
{
    public int? CustomerId { get; set; }

    public DateTime? ExpiryDate { get; set; }
}
