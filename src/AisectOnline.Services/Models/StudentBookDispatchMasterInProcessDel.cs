using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentBookDispatchMasterInProcessDel
{
    public int StudentBookDispatchMasterId { get; set; }

    public int? StudentId { get; set; }

    public int? Kioskid { get; set; }

    public string? CourierNo { get; set; }

    public string? CourierName { get; set; }

    public DateTime? CourierDate { get; set; }

    public string? DispatchAt { get; set; }

    public string? DispatchAddress { get; set; }

    public string? DocketNo { get; set; }

    public string? Remark { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CpmmappingId { get; set; }

    public int? DispatchStatus { get; set; }

    public int? ParentSbdmid { get; set; }

    public int? ItemDispatchStatus { get; set; }

    public int? IsDispatchDone { get; set; }

    public DateTime? DocketDate { get; set; }

    public int? StudentCourseFeeId { get; set; }
}
