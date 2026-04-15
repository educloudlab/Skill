using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CourseItemMaster
{
    public int CourseItemId { get; set; }

    public int? CpmmappingId { get; set; }

    public int? ItemId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CourseYear { get; set; }

    public int? Semester { get; set; }

    public virtual CpmmappingMaster? Cpmmapping { get; set; }

    public virtual ItemMaster? Item { get; set; }
}
