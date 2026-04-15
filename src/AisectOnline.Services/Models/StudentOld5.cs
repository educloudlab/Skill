using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentOld5
{
    public int? StudentId { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? Remarks { get; set; }

    public DateTime? Dob { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
