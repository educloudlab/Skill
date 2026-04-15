using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentEnquiry
{
    public int Id { get; set; }

    public int? Kioskid { get; set; }

    public string? EnquiryFormNo { get; set; }

    public string FullName { get; set; } = null!;

    public string MotherName { get; set; } = null!;

    public string FatherName { get; set; } = null!;

    public int Gender { get; set; }

    public int? Category { get; set; }

    public DateOnly? Dob { get; set; }

    public int? ProgrammeApplied { get; set; }

    public int? Nationality { get; set; }

    public int? PlaceOfResidence { get; set; }

    public int? Religion { get; set; }

    public string? FatherContactNo { get; set; }

    public string? CantactNumbers { get; set; }

    public string? EmailStudent { get; set; }

    public string? EmailParent { get; set; }

    public string? Address { get; set; }

    public int? City { get; set; }

    public int? State { get; set; }

    public int? Pin { get; set; }

    public string? Photo { get; set; }

    public string? Status { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
