using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class DinstaLoginBk
{
    public int Id { get; set; }

    public string? ReqKioskcode { get; set; }

    public string? ReqMerchantkey { get; set; }

    public string? ReqToken { get; set; }

    public string? ReqEmail { get; set; }

    public string? ResStatus { get; set; }

    public string? ResCode { get; set; }

    public string? ResData { get; set; }

    public string? ResMessage { get; set; }

    public string? ResChecksum { get; set; }

    public string? Createdby { get; set; }

    public DateTime? Createdon { get; set; }
}
