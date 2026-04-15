using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class DeletedStudent
{
    public int Id { get; set; }

    public int? StudentId { get; set; }

    public string? StudentName { get; set; }

    public string? Course { get; set; }

    public string? Session { get; set; }

    public string? KioskCode { get; set; }

    public DateTime? CreatedOn { get; set; }
}
