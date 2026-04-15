using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentWithArchiveStatusBeforeJan21
{
    public string? Session { get; set; }

    public int? Sessionorder { get; set; }

    public int Studentid { get; set; }

    public int Status { get; set; }

    public int StudentcoursefeeId { get; set; }

    public int ScfStatus { get; set; }

    public string Requestno { get; set; } = null!;
}
