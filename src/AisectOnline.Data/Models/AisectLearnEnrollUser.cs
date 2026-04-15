using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AisectLearnEnrollUser
{
    public int AutoId { get; set; }

    public int? StudentId { get; set; }

    public string? CourseId { get; set; }

    public int? RoleId { get; set; }

    public int? UserId { get; set; }

    public DateTime? CreateDate { get; set; }
}
