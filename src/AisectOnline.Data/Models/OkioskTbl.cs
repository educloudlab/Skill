using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class OkioskTbl
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public string? CoordinatorName { get; set; }

    public string? InstituteName { get; set; }

    public string? Address { get; set; }

    public string? ContactNumber { get; set; }

    public string? Email { get; set; }

    public string? City { get; set; }

    public string? State { get; set; }

    public string? District { get; set; }

    public int? PinCode { get; set; }

    public string? Facilities { get; set; }

    public string? SelectedClasses { get; set; }

    public bool? DeclarationAccepted { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public int? IsActive { get; set; }
}
