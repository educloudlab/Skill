using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Report
{
    public int StudentId { get; set; }

    public string RequestNo { get; set; } = null!;

    public string FirstName { get; set; } = null!;

    public string LastName { get; set; } = null!;

    public string? FatherName { get; set; }

    public int ProgrammeId { get; set; }

    public int Status { get; set; }

    public string? OfflineBranchcode { get; set; }

    public int SessionId { get; set; }

    public int CourseId { get; set; }

    public string? Course { get; set; }

    public string TransactionId { get; set; } = null!;

    public string? CurrentKiosk { get; set; }

    public decimal TransactionAmount { get; set; }

    public string? PaymentFrom { get; set; }
}
