using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class DepartmentMasterGr
{
    public int Uid { get; set; }

    public int? DepartmentId { get; set; }

    public string? DepartmentCode { get; set; }

    public string? DepartmentName { get; set; }

    public bool? Status { get; set; }

    public bool? IsLock { get; set; }

    public bool? SubDepartment { get; set; }

    public int? CityId { get; set; }

    public int? StateId { get; set; }

    public string? Address { get; set; }

    public DateTime? CreatedDate { get; set; }

    public int? Isactive { get; set; }
}
