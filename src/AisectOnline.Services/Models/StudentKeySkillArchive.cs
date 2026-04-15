using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentKeySkillArchive
{
    public int StudentKeySkillId { get; set; }

    public int? KeySkillId { get; set; }

    public int? StudentId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
