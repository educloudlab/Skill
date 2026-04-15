using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CardTransactionDetail
{
    public int OnlineCardTransId { get; set; }

    public string Merchantid { get; set; } = null!;

    public string? Vender { get; set; }

    public string? Partner { get; set; }

    public string? Cutomeripaddress { get; set; }

    public int MerchantTransctionid { get; set; }

    public string? Orderrefnumber { get; set; }

    public int? KioskId { get; set; }

    public int? StudentId { get; set; }

    public int? UserId { get; set; }

    public string? EWalletTransactionId { get; set; }

    public int? KisokServiceId { get; set; }

    public string? Responseurl { get; set; }

    public string? Responsemethod { get; set; }

    public string? CurrCode { get; set; }

    public string? Invoiceno { get; set; }

    public string? Merchanttype { get; set; }

    public decimal? Amount { get; set; }

    public string? Timeoffset { get; set; }

    public string? Cardtype { get; set; }

    public string? Name { get; set; }

    public string? InstrType { get; set; }

    public string? Remark { get; set; }

    public string? Ext1 { get; set; }

    public string? Ext2 { get; set; }

    public string? Ext3 { get; set; }

    public string? Ext4 { get; set; }

    public string? Ext5 { get; set; }

    public string? OpgRespCode { get; set; }

    public string? Respmessage { get; set; }

    public string? TxnId { get; set; }

    public string? AuthCode { get; set; }

    public string? Rrn { get; set; }

    public string? CvrespCode { get; set; }

    public string? CvrespCookie { get; set; }

    public string? Fdmsscore { get; set; }

    public string? Fdmsresult { get; set; }

    public string? RespPaymentId { get; set; }
}
