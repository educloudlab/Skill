using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ExamPaper2025
{
    public int ExamPaperId { get; set; }

    public int? SemNo { get; set; }

    public string? Course { get; set; }

    public int? PaperOrder { get; set; }

    public string? Paper { get; set; }

    public string? SubjectGroup { get; set; }

    public int? SessionId { get; set; }

    public int? UniversityId { get; set; }

    public int IsActive { get; set; }
}
