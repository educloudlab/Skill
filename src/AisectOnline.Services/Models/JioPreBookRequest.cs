using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class JioPreBookRequest
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public int Kioskid { get; set; }

    public string? CallingSystem { get; set; }

    public string? TxnId { get; set; }

    public string? SourceTxnType { get; set; }

    public string? ServiceId { get; set; }

    public string? PrmId { get; set; }

    public string? AgentId { get; set; }

    public string? PosCode { get; set; }

    public string? ChannelId { get; set; }

    public int? PinCode { get; set; }

    public string? MobileNo { get; set; }

    public string? ReturnUrl { get; set; }

    public string? CheckSum { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }
}
