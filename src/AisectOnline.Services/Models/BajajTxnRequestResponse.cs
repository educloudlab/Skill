using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BajajTxnRequestResponse
{
    public int ParterPaymentInfoId { get; set; }

    public string? VkidRequest { get; set; }

    public string? OrderId { get; set; }

    public string? Screquest { get; set; }

    public int? RequestAmount { get; set; }

    public string? ReturnUrl { get; set; }

    public string? RequestedString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? ClientOrderNo { get; set; }

    public string? RequestJson { get; set; }

    public string? ResponseJson { get; set; }

    public string? PaymentMode { get; set; }

    public string? Utn { get; set; }

    public string? ResponseAmount { get; set; }

    public string? Channel { get; set; }

    public string? TxnStatusResponse { get; set; }

    public string? TxnIdResponse { get; set; }

    public string? Vkidresponse { get; set; }

    public DateTime? TransactionnDateResponse { get; set; }

    public string? TxnMessageResponse { get; set; }

    public string? Scresponse { get; set; }

    public string? UserId { get; set; }

    public string? ClientOrderNoResponse { get; set; }

    public string? ResponseString { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
