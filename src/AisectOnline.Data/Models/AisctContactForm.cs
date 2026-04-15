using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AisctContactForm
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Interest { get; set; }

    public string? Address { get; set; }

    public string? Location { get; set; }

    public string? State { get; set; }

    public string? City { get; set; }

    public string? Message { get; set; }

    public DateTime? CreatedOn { get; set; }
}
