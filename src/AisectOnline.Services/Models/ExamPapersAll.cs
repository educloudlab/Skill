using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ExamPapersAll
{
    public string? Servicename { get; set; }

    public string? ServiceId { get; set; }

    public string? Academy { get; set; }

    public string? CourseCategoryId { get; set; }

    public string? ProgrammeName { get; set; }

    public string? ProgrammeId { get; set; }

    public string? CourseName { get; set; }

    public string? CourseShortName { get; set; }

    public string? CourseId { get; set; }

    public string? CourseCode { get; set; }

    public string? Session { get; set; }

    public string? SessionId { get; set; }

    public double? AssignmentMax { get; set; }

    public double? AssignmentMin { get; set; }

    public double? PracticalMax { get; set; }

    public double? PracticalMin { get; set; }

    public double? LabMax { get; set; }

    public double? LabMin { get; set; }

    public string? PapersLimit { get; set; }

    public string? PaerName { get; set; }

    public string? Courseid1 { get; set; }
}
