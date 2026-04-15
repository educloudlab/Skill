using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Audatum
{
    public string RegistrationNo { get; set; } = null!;

    public string? BranchCode { get; set; }

    public string? StudentName { get; set; }

    public string? CourseName { get; set; }

    public string? Session { get; set; }
}
