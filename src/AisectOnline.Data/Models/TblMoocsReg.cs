using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class TblMoocsReg
{
    public int StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Email { get; set; }

    public string? MobileNo { get; set; }

    public int? CourseId { get; set; }

    public string? Category { get; set; }

    public string? University { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public DateTime? RegDate { get; set; }
}
