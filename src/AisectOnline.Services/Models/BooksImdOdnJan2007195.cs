using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BooksImdOdnJan2007195
{
    public int BooksInventoryMgmtDetailId { get; set; }

    public int? BookId { get; set; }

    public int? PublicationId { get; set; }

    public int? AutherId { get; set; }

    public int? SupplierId { get; set; }

    public int? MediumId { get; set; }

    public decimal? Quantity { get; set; }

    public decimal? CostPerUnit { get; set; }

    public string? Remark { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? DispatchOrderNo { get; set; }
}
