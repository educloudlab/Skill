using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class OlympiadStudent
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public int? CustomerId { get; set; }

    public string? NameOfSchoolCollegeInstitute { get; set; }

    public string? AddressOfSchoolCollegeInstitute { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? Class { get; set; }

    public DateTime? DateOfBirth { get; set; }

    public int? Gender { get; set; }

    public string? NameOfGuardian { get; set; }

    public string? ContactNumber { get; set; }

    public string? EmailId { get; set; }

    public string? City { get; set; }

    public int? State { get; set; }

    public int? District { get; set; }

    public string? ExamCenter { get; set; }

    public int? SelectOlympiadExam { get; set; }

    public int? FeeStatus { get; set; }

    public int? TransactionId { get; set; }

    public double? TransactionAmount { get; set; }

    public DateTime? TransactionDate { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
