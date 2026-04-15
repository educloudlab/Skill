using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Registration
{
    public int RId { get; set; }

    public string EmailId { get; set; } = null!;

    public string CId { get; set; } = null!;

    public bool IsActive { get; set; }

    public DateTime Dot { get; set; }

    public virtual ICollection<StudentComp> StudentComps { get; set; } = new List<StudentComp>();
}
