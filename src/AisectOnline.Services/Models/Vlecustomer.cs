using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Vlecustomer
{
    public int CustomerId { get; set; }

    public string? Name { get; set; }

    public DateOnly? Dob { get; set; }

    public string? Mobile { get; set; }

    public string? State { get; set; }

    public DateTime? CreatedOn { get; set; }
}
