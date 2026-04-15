using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class CitizenLoginRegistration
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Mobile { get; set; }

    public string? EMail { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public DateTime? CreatedOn { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public bool? IsActive { get; set; }
}
