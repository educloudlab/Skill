using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class RojgarEmitraLead
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? Name { get; set; }

    public string? FatherName { get; set; }

    public string? Address { get; set; }

    public string? MobileNo { get; set; }

    public DateTime? Dob { get; set; }

    public string? AadharNo { get; set; }

    public string? Education { get; set; }

    public string? CompanyNameAndPlace { get; set; }

    public string? SalaryDrawnPmonth { get; set; }

    public string? ExperienceIn { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public string? WorkExperience { get; set; }
}
