using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BirthDaywishTimerUpdate
{
    public int Id { get; set; }

    public DateOnly? EventDate { get; set; }

    public bool? Yn { get; set; }

    public DateTime? EventDateTime { get; set; }

    public int? TotalCount { get; set; }
}
