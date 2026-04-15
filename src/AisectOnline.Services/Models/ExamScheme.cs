using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ExamScheme
{
    public int Id { get; set; }

    public int? ExamSchemeId { get; set; }

    public string? University { get; set; }

    public int? SessionId { get; set; }

    public string? Status { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public int? IsActive { get; set; }
}
