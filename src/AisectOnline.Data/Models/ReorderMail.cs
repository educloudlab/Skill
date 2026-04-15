using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ReorderMail
{
    public int? BookId { get; set; }

    public string? BookName { get; set; }

    public string? BookCode { get; set; }

    public string? MediumName { get; set; }

    public decimal? CurrentQuantity { get; set; }

    public int? ReorderPoint { get; set; }

    public DateTime? Createdon { get; set; }
}
