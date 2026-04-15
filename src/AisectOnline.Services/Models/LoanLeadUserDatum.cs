using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class LoanLeadUserDatum
{
    public int LoanId { get; set; }

    public string? CustomerName { get; set; }

    public string? FateherName { get; set; }

    public DateTime? Dob { get; set; }

    public string? Place { get; set; }

    public string? District { get; set; }

    public string? State { get; set; }

    public string? MobileNumber { get; set; }

    public string? EmailId { get; set; }

    public string? ResLoanId { get; set; }

    public string? Type { get; set; }

    public int? KioskId { get; set; }
}
