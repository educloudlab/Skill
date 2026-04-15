using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentCourseFeeDetails271123
{
    public int StudentCourseFeeDetailId { get; set; }

    public int? StudentCourseFeeId { get; set; }

    public int? FeeTypeId { get; set; }

    public int? Month { get; set; }

    public decimal? Fee { get; set; }

    public DateTime? FeeStartDate { get; set; }

    public DateTime? FeeEndDate { get; set; }

    public DateTime? FeeReceivedDate { get; set; }

    public int? ReceivedBy { get; set; }

    public string? TransactionId { get; set; }

    public string? Remark { get; set; }

    public int? ExamSession { get; set; }
}
