using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentComp
{
    public int CompId { get; set; }

    public int RegId { get; set; }

    public string? ContentLink { get; set; }

    public string? ContentFiles { get; set; }

    public int? Courseid { get; set; }

    public string? Emailid { get; set; }

    public DateTime? DandT { get; set; }

    public virtual Registration Reg { get; set; } = null!;
}
