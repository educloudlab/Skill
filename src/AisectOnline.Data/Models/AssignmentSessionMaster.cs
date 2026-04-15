using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AssignmentSessionMaster
{
    public int Id { get; set; }

    public int? SessionId { get; set; }

    public DateTime? StartDate { get; set; }

    public DateTime? EndDate { get; set; }

    public int? Isactive { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
