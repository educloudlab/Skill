using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentBookSubjectDeleted
{
    public int StudentBookSubjectDelId { get; set; }

    public int StudentBookSubjectId { get; set; }

    public int? Studentid { get; set; }

    public int? Subjectid { get; set; }

    public int? CpmmappingId { get; set; }

    public int? Isopted { get; set; }

    public int? StudentCourseFeeId { get; set; }

    public DateOnly? CreatedOn { get; set; }
}
