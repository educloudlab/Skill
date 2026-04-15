using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class DownloadDocumentHeading
{
    public int Id { get; set; }

    public string? HeadingName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? IsDisplay { get; set; }
}
