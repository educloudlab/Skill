using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AlisonStudentMaster
{
    public string Email { get; set; } = null!;

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? City { get; set; }

    public string? Country { get; set; }

    public string? MobileNo { get; set; }

    public DateTime? CreateOn { get; set; }

    public bool? IsBlocked { get; set; }

    public string? Tags { get; set; }

    public string? AisectCourseId { get; set; }

    public string? AlisonCourseCode { get; set; }

    public string? Password { get; set; }

    public bool? IsActive { get; set; }

    public string? RequestUrlA { get; set; }

    public int? LoginTypeId { get; set; }

    public string? ReferenceNo { get; set; }

    public int? StudentId { get; set; }

    public int? IsMailSent { get; set; }

    public int Id { get; set; }
}
