using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class BookPriceList
{
    public int Id { get; set; }

    public string? BookCode { get; set; }

    public string? BookName { get; set; }

    public double? Price { get; set; }

    public string? Course { get; set; }

    public string? Medium { get; set; }

    public string? MaterialType { get; set; }

    public int? MediumId { get; set; }
}
