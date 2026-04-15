using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class OlpstudentReg
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? SchoolName { get; set; }

    public string? SchoolAddress { get; set; }

    public string? FullName { get; set; }

    public string? Class { get; set; }

    public DateOnly? DateOfBirth { get; set; }

    public string? Gender { get; set; }

    public string? GuardianName { get; set; }

    public string? ContactNumber { get; set; }

    public string? Email { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? District { get; set; }

    public string? ExamCentre { get; set; }

    public string? OlympiadClass { get; set; }

    public string? UpadtedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
