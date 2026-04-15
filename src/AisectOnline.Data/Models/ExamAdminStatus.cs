using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ExamAdminStatus
{
    public int Sno { get; set; }

    public string? BranchCode { get; set; }

    public string? RegistrationNumber { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? Eppnumber { get; set; }

    public string? Session { get; set; }
}
