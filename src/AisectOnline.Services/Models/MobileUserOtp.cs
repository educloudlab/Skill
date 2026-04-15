using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MobileUserOtp
{
    public string MobileNo { get; set; } = null!;

    public string Otp { get; set; } = null!;

    public int? RoleId { get; set; }

    public DateTime? CreateOn { get; set; }
}
