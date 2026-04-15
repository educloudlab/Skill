using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BookMaster
{
    public int BookId { get; set; }

    public string? BookName { get; set; }

    public string? BookCode { get; set; }

    public int? MediumId { get; set; }

    public string? MediumName { get; set; }

    public decimal? Price { get; set; }

    public int? AuthorId { get; set; }

    public int? PublicationId { get; set; }

    public int? SupplierId { get; set; }

    public int? ReOrderPoint { get; set; }

    public string? Specialization { get; set; }

    public string? Remark1 { get; set; }

    public string? Remark2 { get; set; }

    public string? Remark3 { get; set; }

    public bool? IsActive { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual MasterList? Author { get; set; }

    public virtual ICollection<BookSubjectMaster> BookSubjectMasters { get; set; } = new List<BookSubjectMaster>();

    public virtual MasterList? Medium { get; set; }

    public virtual MasterList? Publication { get; set; }

    public virtual MasterList? Supplier { get; set; }
}
