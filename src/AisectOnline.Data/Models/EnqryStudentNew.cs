using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class EnqryStudentNew
{
    public int EnqryId { get; set; }

    public string StudentName { get; set; } = null!;

    public string StudentMobile { get; set; } = null!;

    public string StudentEmailId { get; set; } = null!;

    public string StudentAddress { get; set; } = null!;

    public string StudentCity { get; set; } = null!;

    public string StudentCountry { get; set; } = null!;

    public string StudentUniversity { get; set; } = null!;

    public string StudentEduType { get; set; } = null!;

    public string StudentCourses { get; set; } = null!;
}
