using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudyNote
{
    public int StudyId { get; set; }

    public string? StudyNotes { get; set; }

    public int? CourseId { get; set; }

    public string? EmailId { get; set; }

    public DateTime? NoteDate { get; set; }
}
