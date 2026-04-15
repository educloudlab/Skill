using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentBookSubjectArchive
{
    public int Studentbooksubjectid { get; set; }

    public int? Studentid { get; set; }

    public int? Subjectid { get; set; }

    public int? CpmmappingId { get; set; }

    public int? Isopted { get; set; }
}
