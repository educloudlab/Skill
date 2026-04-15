using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StreamMaster
{
    public int StreamId { get; set; }

    public string? StreamName { get; set; }

    public bool? IsActive { get; set; }

    public int? QualificationId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<StudentQualification> StudentQualifications { get; set; } = new List<StudentQualification>();
}
