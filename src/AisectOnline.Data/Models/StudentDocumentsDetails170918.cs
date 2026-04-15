using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentDocumentsDetails170918
{
    public int StudentDocsId { get; set; }

    public int? DocumentId { get; set; }

    public int? StudentId { get; set; }

    public string? DocumentName { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
