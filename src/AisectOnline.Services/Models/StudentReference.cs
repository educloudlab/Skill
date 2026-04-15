using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentReference
{
    public int StudentReferenceId { get; set; }

    public string? ReferenceName { get; set; }

    public string? Designation { get; set; }

    public string? Company { get; set; }

    public string? PhoneNo { get; set; }

    public int? StudentId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }
}
