using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BookPriceList2
{
    public double? Id { get; set; }

    public string? BookCode { get; set; }

    public string? BookName { get; set; }

    public double? Price { get; set; }

    public string? Course { get; set; }

    public string? Medium { get; set; }

    public string? MaterialType { get; set; }

    public double? MediumId { get; set; }
}
