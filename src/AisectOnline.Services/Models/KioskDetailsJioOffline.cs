using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class KioskDetailsJioOffline
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? KioskCode { get; set; }

    public string? KioskName { get; set; }

    public string? KioskOwnerName { get; set; }

    public string? KioskAdhaar { get; set; }

    public string? KioskMobile { get; set; }

    public string? KioskDob { get; set; }

    public string? KioskEmail { get; set; }

    public int? KioskPinCode { get; set; }

    public string? KioskAddress { get; set; }

    public int? KioskStateId { get; set; }

    public int? KioskDistrictId { get; set; }

    public int? KioskBlockId { get; set; }

    public string? KioskCity { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? Gender { get; set; }
}
