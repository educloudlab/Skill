using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AirtelConsent
{
    public int Id { get; set; }

    public string? Consent { get; set; }

    public DateTime? CreatedOn { get; set; }
}
