using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AisectLearnCreateUser
{
    public int AutoId { get; set; }

    public int StudentId { get; set; }

    public int? Userid { get; set; }

    public string? IdNumber { get; set; }

    public string? FirstName { get; set; }

    public string? LastName { get; set; }

    public string? MobileNumber { get; set; }

    public string? Email { get; set; }

    public string? Department { get; set; }

    public string? Institution { get; set; }

    public string? UserName { get; set; }

    public string? Password { get; set; }

    public DateTime? CreatedDate { get; set; }

    public string? ResponseJson { get; set; }

    public string? RequestJson { get; set; }
}
