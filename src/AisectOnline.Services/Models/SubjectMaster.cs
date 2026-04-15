using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class SubjectMaster
{
    public int SubjectId { get; set; }

    public string? SubjectName { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual ICollection<BookSubjectMaster> BookSubjectMasters { get; set; } = new List<BookSubjectMaster>();
}
