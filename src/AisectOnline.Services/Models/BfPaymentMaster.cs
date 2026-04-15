using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BfPaymentMaster
{
    public long OwnTransId { get; set; }

    public long? RequestId { get; set; }

    public string? BaflTranId { get; set; }

    public string? PartnerId { get; set; }

    public string? Urn { get; set; }

    public decimal? CustPaidAmount { get; set; }

    public string? PartnerTranId { get; set; }

    public string? PaymentMode { get; set; }

    public string? PartnerRefNo { get; set; }

    public string? AdditionalInfo1 { get; set; }

    public string? AdditionalInfo2 { get; set; }

    public string? Urnstatus { get; set; }

    public string? RejectReason { get; set; }

    public int? Kioskid { get; set; }

    public DateTime? RequestDate { get; set; }

    public string? BaflTranIdRes { get; set; }

    public string? UrnRes { get; set; }

    public string? PartnerTranIdRes { get; set; }

    public string? PartnerRefNoRes { get; set; }

    public DateTime? ResponseDate { get; set; }

    public string? OperationStatus { get; set; }

    public string? ErrorInResponse { get; set; }

    public int? EvoletTransactionId { get; set; }

    public DateTime? EvoletTransactionTime { get; set; }

    public virtual Kioskdatum? Kiosk { get; set; }

    public virtual BfResponseMaster? Request { get; set; }
}
