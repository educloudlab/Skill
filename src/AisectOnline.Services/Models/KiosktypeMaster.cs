using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KiosktypeMaster
{
    public int KiosktypeId { get; set; }

    public string TypeName { get; set; } = null!;

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateOnly? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public virtual ICollection<KioskserviceMaster> KioskserviceMasters { get; set; } = new List<KioskserviceMaster>();

    public virtual ICollection<ProgrammeMaster> ProgrammeMasters { get; set; } = new List<ProgrammeMaster>();

    public virtual ICollection<SessionMaster> SessionMasters { get; set; } = new List<SessionMaster>();
}
