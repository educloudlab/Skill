using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentItemDispatchDetail
{
    public int StudentItemDispatchDetailId { get; set; }

    public int? StudentBookDispatchMasterId { get; set; }

    public int? ItemId { get; set; }

    public int? IsBlocked { get; set; }

    public int? SuperParentSbdmid { get; set; }
}
