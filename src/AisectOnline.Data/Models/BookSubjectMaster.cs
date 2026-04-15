using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BookSubjectMaster
{
    public int BookSubjectId { get; set; }

    public int? BookId { get; set; }

    public int? SubjectId { get; set; }

    public int? CpmmappingId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CourseYear { get; set; }

    public int? Semester { get; set; }

    public bool? Isoptional { get; set; }

    public virtual BookMaster? Book { get; set; }

    public virtual CpmmappingMaster? Cpmmapping { get; set; }

    public virtual SubjectMaster? Subject { get; set; }
}
