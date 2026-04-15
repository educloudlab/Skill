using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentDocumentuploaded
{
    public int DocumentId { get; set; }

    public int? StudentId { get; set; }

    public int? KioskId { get; set; }

    public string? DocumentName { get; set; }

    public string? FileName { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public string? FilePath { get; set; }

    public string? Status { get; set; }

    public string? Remarks { get; set; }

    public string? UploadedStatus { get; set; }

    public int? Updatedby { get; set; }
}
