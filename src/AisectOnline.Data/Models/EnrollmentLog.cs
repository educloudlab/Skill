using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class EnrollmentLog
{
    public int Id { get; set; }

    public string EnrollmentNo { get; set; } = null!;

    public DateTime? Date { get; set; }
}
