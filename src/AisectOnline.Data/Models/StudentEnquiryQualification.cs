using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentEnquiryQualification
{
    public int Id { get; set; }

    public int EnquiryId { get; set; }

    public int? ExaminationId { get; set; }

    public string? BroardUniv { get; set; }

    public string? YearOfPass { get; set; }

    public string? Subject { get; set; }

    public string? Percentage { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatyedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
