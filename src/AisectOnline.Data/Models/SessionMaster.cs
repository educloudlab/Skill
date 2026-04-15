using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class SessionMaster
{
    public int SessionId { get; set; }

    public int? SessionMasterListId { get; set; }

    public string? Session { get; set; }

    public DateTime? SessionStartDate { get; set; }

    public DateTime? SessionEndDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? Status { get; set; }

    public int? PublishedBy { get; set; }

    public DateTime? PublishedDate { get; set; }

    public int? ReviewBy { get; set; }

    public DateTime? ReviewDate { get; set; }

    public int? AppRejBy { get; set; }

    public DateTime? AppRejDate { get; set; }

    public bool? IsActive { get; set; }

    public int? KioskTypeId { get; set; }

    public int? KioskServiceId { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? SessionOrder { get; set; }

    public virtual KiosktypeMaster? KioskType { get; set; }

    public virtual ICollection<SessionCourseFee> SessionCourseFees { get; set; } = new List<SessionCourseFee>();

    public virtual ICollection<SessionOpenRole> SessionOpenRoles { get; set; } = new List<SessionOpenRole>();

    public virtual ICollection<StudentCourseFee> StudentCourseFees { get; set; } = new List<StudentCourseFee>();
}
