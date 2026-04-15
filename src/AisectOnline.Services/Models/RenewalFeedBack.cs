using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class RenewalFeedBack
{
    public int Id { get; set; }

    public int? CustomerId { get; set; }

    public int? IsSubmitted { get; set; }

    public DateTime? CreatedOn { get; set; }
}
