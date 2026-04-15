using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CourseFeeMode
{
    public int Id { get; set; }

    public string? Value { get; set; }

    public bool? IsActive { get; set; }
}
