using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class ErrorLogGr
{
    public int Id { get; set; }

    public int? ErrorNumber { get; set; }

    public string? ErrorProcedure { get; set; }

    public int? ErrorLine { get; set; }

    public string? ErrorMessage { get; set; }

    public DateTime? ErrorDate { get; set; }
}
