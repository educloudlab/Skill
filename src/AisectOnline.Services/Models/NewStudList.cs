using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class NewStudList
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public int? StudentCoursefeeId { get; set; }

    public int? CourseId { get; set; }
}
