using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Sef190623
{
    public int ExamFormId { get; set; }

    public int StudentId { get; set; }

    public string? RegistrationNo { get; set; }

    public string? RollNo { get; set; }

    public string? LastExamEnrollmentNo { get; set; }

    public string? CurrentExamName { get; set; }

    public string? CaughtInCopyingAct { get; set; }

    public string? AdmissionInOtherUniversity { get; set; }

    public string? ExamCenter { get; set; }

    public int? ExamCenterState { get; set; }

    public int? ExamCenterDistrict { get; set; }

    public int? ExamFormStatus { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public int? KioskId { get; set; }

    public string? CourseSubjects { get; set; }

    public int? StudentCourseFeeId { get; set; }

    public string? PhotoIdNo { get; set; }

    public bool? IsBacklog { get; set; }

    public string? XrollNo { get; set; }

    public string? TheoryBacklog { get; set; }

    public string? PracticalBacklog { get; set; }

    public decimal? StudentBackLogFee { get; set; }

    public int? ExamSession { get; set; }

    public int? Semester { get; set; }
}
