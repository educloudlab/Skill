using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Temprenewalreceipt
{
    public int Id { get; set; }

    public string? FirstName { get; set; }

    public string? KioskCode { get; set; }

    public string? RenewalCode { get; set; }

    public string? AcademyName { get; set; }

    public string? ProductId { get; set; }

    public string? OriginalAmount { get; set; }

    public string? FinalAmount { get; set; }

    public string? TransactionId { get; set; }

    public string? Remarks { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? KioskId { get; set; }

    public string PaymentId { get; set; } = null!;

    public string? Expr1 { get; set; }

    public string? Address { get; set; }

    public string StateName { get; set; } = null!;

    public int? Stateid { get; set; }
}
