using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Lscmaster
{
    public int Id { get; set; }

    public string? Lsccode { get; set; }

    public string? Lscname { get; set; }

    public string? Address { get; set; }

    public string? City { get; set; }

    public string? District { get; set; }

    public string? CoordinatorName { get; set; }

    public string? ContactNo { get; set; }

    public string? Email { get; set; }

    public string? Regional { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }
}
