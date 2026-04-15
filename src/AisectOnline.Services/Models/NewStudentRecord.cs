using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class NewStudentRecord
{
    public int Id { get; set; }

    public string? StudentName { get; set; }

    public string? Dob { get; set; }

    public string? Address { get; set; }

    public string? Phone { get; set; }

    public string? Updated { get; set; }
}
