using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Coursefee07072023
{
    public int ProgrammeId { get; set; }

    public string? ProgrammeName { get; set; }

    public int? KiosktypeId { get; set; }

    public int? KioskserviceId { get; set; }

    public int? NoOfCourse { get; set; }

    public DateTime? ActiveDate { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }

    public int? CourseCategoryId { get; set; }

    public int? DeptId { get; set; }

    public string? Skill { get; set; }

    public string? Mscgroup { get; set; }

    public bool? HasLateFee { get; set; }

    public double? Discount { get; set; }

    public string? Eligibillity { get; set; }
}
