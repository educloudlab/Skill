using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentBookDispatchDetail
{
    public int StudentBookDispatchDetailId { get; set; }

    public int? StudentBookDispatchMasterId { get; set; }

    public int? BookId { get; set; }

    /// <summary>
    /// 2: Students Are Pending; 1: Book is Blocked; 0:Book is Dipatched;
    /// </summary>
    public int? IsBlocked { get; set; }

    public int? SuperParentSbdmid { get; set; }
}
