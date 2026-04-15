using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ExamPaperRntu
{
    public string? ExamPaperId { get; set; }

    public string? ExamCourseId { get; set; }

    public string? ExamCourse { get; set; }

    public double? SemNo { get; set; }

    public string? Course { get; set; }

    public double? CourseId { get; set; }

    public double? PaperOrder { get; set; }

    public string? Paper { get; set; }

    public string? SubjectGroup { get; set; }

    public string? SessionId { get; set; }

    public string? UniversityId { get; set; }

    public double? PracticalMax { get; set; }

    public double? AssignmentMax { get; set; }

    public double? LabMax { get; set; }

    public string? TypePractical { get; set; }

    public string? TypeAssignment { get; set; }

    public string? TypeLab { get; set; }

    public string? SubjectType { get; set; }

    public string? F19 { get; set; }
}
