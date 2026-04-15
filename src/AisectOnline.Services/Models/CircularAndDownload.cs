using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CircularAndDownload
{
    public int Sno { get; set; }

    public string? DocumentType { get; set; }

    public string? DocumentTitle { get; set; }

    public int? HeadingId { get; set; }

    public string? DocumentFile { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public DateTime? CircularDate { get; set; }

    public int? ActiveStatus { get; set; }
}
