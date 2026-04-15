using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentDispatchItem
{
    public int StudentDispatchItemId { get; set; }

    public int? DispatchItemId { get; set; }

    public int? DispatchId { get; set; }

    public virtual StudentDispatch? Dispatch { get; set; }

    public virtual MasterList? DispatchItem { get; set; }
}
