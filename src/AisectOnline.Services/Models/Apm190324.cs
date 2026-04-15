using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Apm190324
{
    public int Id { get; set; }

    public string? RegistrationNo { get; set; }

    public int? SchemeId { get; set; }

    public string? SubjectName { get; set; }

    public int? AssignmentMarks { get; set; }

    public int? PracticalMarks { get; set; }

    public string? KioskCode { get; set; }

    public string? Course { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? SessionId { get; set; }
}
