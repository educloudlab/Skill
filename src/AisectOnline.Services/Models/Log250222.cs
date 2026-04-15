using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Log250222
{
    public int Id { get; set; }

    public DateTime Date { get; set; }

    public string Level { get; set; } = null!;

    public string Logger { get; set; } = null!;

    public string? MachineName { get; set; }

    public string? BrowserName { get; set; }

    public string? ApplicationUrl { get; set; }

    public string? ExceptionSource { get; set; }

    public string? PostedFormValues { get; set; }

    public string? SessionValues { get; set; }

    public string? User { get; set; }

    public string Message { get; set; } = null!;

    public string? StackTrace { get; set; }
}
