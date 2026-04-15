using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class HighEndApilogStudent
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public string? ReqApi1 { get; set; }

    public string? ResApi1 { get; set; }

    public string? ReqApi2 { get; set; }

    public string? ResApi2 { get; set; }

    public string? LoginPassword { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
