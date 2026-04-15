using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ExamSubjectMaster
{
    public double? AisectOldCourseId { get; set; }

    public double? ExamSchemeId { get; set; }

    public string? CourseName { get; set; }

    public double? SemNo { get; set; }

    public string? Subject { get; set; }

    public double? Thmax { get; set; }

    public double? Thmin { get; set; }

    public double? Prmax { get; set; }

    public double? PrMin { get; set; }

    public double? Asmax { get; set; }

    public double? Asmin { get; set; }

    public double? TotalMarks { get; set; }

    public double? NewCourseId { get; set; }
}
