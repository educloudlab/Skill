using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ReorderPoint
{
    public int? BookId { get; set; }

    public string? BookName { get; set; }

    public string? BookCode { get; set; }

    public string? MediumName { get; set; }

    public decimal? CurrentQuantity { get; set; }

    public int? ReorderPoint1 { get; set; }

    public DateTime? Createdon { get; set; }
}
