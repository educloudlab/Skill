using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ExamPapersNew
{
    public int ExamPaperId { get; set; }

    public int? ExamCourseId { get; set; }

    public string? ExamCourse { get; set; }

    public int? SemNo { get; set; }

    public string? Course { get; set; }

    public int? CourseId { get; set; }

    public int? PaperOrder { get; set; }

    public string? Paper { get; set; }

    public string? SubjectGroup { get; set; }

    public int? SessionId { get; set; }

    public int? UniversityId { get; set; }

    public double? PracticalMax { get; set; }

    public double? AssignmentMax { get; set; }

    public double? LabMax { get; set; }

    public string? Practical { get; set; }

    public string? Assignment { get; set; }

    public string? Lab { get; set; }

    public string? SubjectType { get; set; }
}
