using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ExamSchemePaper
{
    public int Id { get; set; }

    public int? ExamSchemeId { get; set; }

    public int? ExamPaperId { get; set; }

    public string? ExamPaperName { get; set; }

    public int? ExamPaperIdAddOn { get; set; }

    public string? ExamPaperAddOnName { get; set; }

    public int? CourseId { get; set; }

    public string? CourseName { get; set; }

    public string? Type { get; set; }

    public int? Max { get; set; }

    public int? Min { get; set; }

    public int? IsActive { get; set; }

    public string? CretaedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
