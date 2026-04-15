using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskHardwareDetail
{
    public int Customerid { get; set; }

    public string? Tftpiii { get; set; }

    public string? Tftpiv { get; set; }

    public string? Crtpiii { get; set; }

    public string? Crtpiv { get; set; }

    public string? Printer { get; set; }

    public string? DigitalCamera { get; set; }

    public string? PowerBackup { get; set; }

    public string? BiometricDevice { get; set; }

    public string? Cctvcamera { get; set; }

    public string? Lcdprojector { get; set; }

    public string? Scanner { get; set; }

    public string? Ac { get; set; }

    public string? WaterCooler { get; set; }

    public string? Others { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }
}
