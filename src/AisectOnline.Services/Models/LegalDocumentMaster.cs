using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class LegalDocumentMaster
{
    public int DocumentId { get; set; }

    public string? DocumentName { get; set; }

    public string? DocumentType { get; set; }

    public bool? IsActive { get; set; }
}
