using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class EnrollmentLog
{
    public int Id { get; set; }

    public string EnrollmentNo { get; set; } = null!;

    public DateTime? Date { get; set; }
}
