using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class EnrollmentMaxValueBackup
{
    public int Id { get; set; }

    public string? GroupName { get; set; }

    public long? MaxValue { get; set; }
}
