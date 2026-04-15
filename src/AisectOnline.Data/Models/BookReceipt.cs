using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BookReceipt
{
    public string? InvoiceNo { get; set; }

    public int StudentId { get; set; }

    public int StudentCourseFeeId { get; set; }

    public string ActualRequestNo { get; set; } = null!;

    public string ServiceName { get; set; } = null!;

    public string StudentName { get; set; } = null!;

    public string? Course { get; set; }

    public string? CourseMedium { get; set; }

    public string TransactionId { get; set; } = null!;

    public DateTime? TransactionDate { get; set; }

    public string? Session { get; set; }

    public string? BookCode { get; set; }

    public string? BookName { get; set; }

    public string? Price { get; set; }

    public string? MaterialType { get; set; }

    public decimal? Bag { get; set; }

    public decimal? Postage { get; set; }

    public decimal? Magazine { get; set; }

    public string? Asm { get; set; }

    public int KioskServiceid { get; set; }

    public DateTime? DispatchDate { get; set; }

    public string? Address { get; set; }

    public string StateName { get; set; } = null!;

    public int? GststateCode { get; set; }

    public string Discount { get; set; } = null!;

    public string BankName { get; set; } = null!;

    public string BankAcNo { get; set; } = null!;

    public string Ifsc { get; set; } = null!;

    public int Cgst { get; set; }

    public int Sgst { get; set; }

    public int Igst { get; set; }

    public string Gstin { get; set; } = null!;

    public int Eppcharges { get; set; }

    public int BagPrice { get; set; }

    public int BagDiscount { get; set; }
}
