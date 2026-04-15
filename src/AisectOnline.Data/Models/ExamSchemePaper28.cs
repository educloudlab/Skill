using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ExamSchemePaper28
{
    public int Id { get; set; }

    public int? ExamPaperId { get; set; }

    public int? ExamPaperAddOnId { get; set; }

    public int? ExamSchemeId { get; set; }

    public string? ExamPaperName { get; set; }

    public string? CourseName { get; set; }

    public string? CourseGroupCode { get; set; }

    public int? Semester { get; set; }

    public int? PaperOrder { get; set; }

    public int? ServiceId { get; set; }

    public int? AssignMax { get; set; }

    public int? AssignMin { get; set; }

    public int? PractMax { get; set; }

    public int? PractMin { get; set; }

    public int? LabMax { get; set; }

    public int? LabMin { get; set; }

    public string? CretaedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
