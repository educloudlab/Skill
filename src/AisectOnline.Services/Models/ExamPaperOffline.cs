using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ExamPaperOffline
{
    public double? PaperId { get; set; }

    public double? SubSno { get; set; }

    public string? SubjectType { get; set; }

    public string? Course { get; set; }

    public string? Code { get; set; }

    public string? PaperName { get; set; }

    public double? Sem { get; set; }

    public int? IsOptional { get; set; }

    public int? SeesionId { get; set; }

    public int? UniversityId { get; set; }
}
