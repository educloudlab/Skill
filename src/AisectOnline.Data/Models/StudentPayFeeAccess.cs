using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentPayFeeAccess
{
    public int Id { get; set; }

    public int? Kioskid { get; set; }

    public DateTime? AccessDate { get; set; }
}
