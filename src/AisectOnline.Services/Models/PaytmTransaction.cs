using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class PaytmTransaction
{
    public int Id { get; set; }

    public string Mid { get; set; } = null!;

    public int OrderId { get; set; }

    public string CustId { get; set; } = null!;

    public int KioskId { get; set; }

    public double TxnAmount { get; set; }

    public string ChannelId { get; set; } = null!;

    public string IndustryTypeId { get; set; } = null!;

    public string Website { get; set; } = null!;

    public string MobileNo { get; set; } = null!;

    public string Email { get; set; } = null!;

    public string? CallbackUrl { get; set; }

    public string? Ipaddress { get; set; }

    public string? ClientBrowser { get; set; }

    public string? SoftwareVersion { get; set; }

    public string? ReqUrl { get; set; }

    public string? ReqJson { get; set; }

    public string? ResTxnId { get; set; }

    public string? ResOrderId { get; set; }

    public string? ResBankTxnId { get; set; }

    public string? ResTxnAmount { get; set; }

    public string? ResCurrency { get; set; }

    public string? ResStatus { get; set; }

    public string? ResRespcode { get; set; }

    public string? ResRespMsg { get; set; }

    public DateTime? ResTxnDate { get; set; }

    public string? ResJson { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? CitizenId { get; set; }
}
