using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class IrctcreqRe
{
    public int Id { get; set; }

    public string? ReqMerchantCode { get; set; }

    public string? ReqReservationId { get; set; }

    public decimal? ReqTxnAmount { get; set; }

    public string? ReqCurrencyType { get; set; }

    public string? ReqAppCode { get; set; }

    public string? ReqPymtMode { get; set; }

    public DateTime? ReqTxnDate { get; set; }

    public string? ReqSecurityId { get; set; }

    public string? ReqRoutingUrl { get; set; }

    public DateTime? CreateDate { get; set; }

    public int? CreatedBy { get; set; }

    public string? ResMerchantCode { get; set; }

    public string? ResReservationId { get; set; }

    public decimal? ResTxnAmount { get; set; }

    public string? ResBankTxnId { get; set; }

    public string? ResStatus { get; set; }

    public string? ResStatusDesc { get; set; }

    public string? ResCheckSum { get; set; }

    public DateTime? UpdateDate { get; set; }

    public int? UpdateBy { get; set; }
}
