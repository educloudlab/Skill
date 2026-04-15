using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentMiniCsv
{
    public long? Sno { get; set; }

    public string RequestNo { get; set; } = null!;

    public string? OldRequestNo { get; set; }

    public string? StudentName { get; set; }

    public string? FatherName { get; set; }

    public string? MotherName { get; set; }

    public string? CourseCategory { get; set; }

    public string? CourseDurationSession { get; set; }

    public string? Kioskcode { get; set; }

    public string? KioskState { get; set; }

    public string? ServiceName { get; set; }

    public string? CourseName { get; set; }

    public string? Gender { get; set; }

    public string? StudentStatus { get; set; }

    public DateTime? DispatchDate { get; set; }

    public DateTime? OrdGenDate { get; set; }

    public string? DispatchNo { get; set; }

    public string? DocketNo { get; set; }

    public int? Duration { get; set; }

    public decimal? FeeBalance { get; set; }

    public string? Medium { get; set; }

    public string? Subjects { get; set; }

    public string? Email { get; set; }

    public string? Mobile { get; set; }

    public string? Aadhar { get; set; }

    public string? MasterValue { get; set; }

    public string? MarksPercentage { get; set; }

    public string? MainSubject { get; set; }

    public string? Division { get; set; }

    public string? Address { get; set; }
}
