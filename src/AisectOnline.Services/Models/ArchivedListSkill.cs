using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ArchivedListSkill
{
    public int Studentid { get; set; }

    public string Requestno { get; set; } = null!;

    public int StudentCourseFeeId { get; set; }

    public int StudentCoursefeeDetailId { get; set; }
}
