using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AbImpsTransactionRequestResponse
{
    public int ImpsTxnId { get; set; }

    public int? Kioskid { get; set; }

    public string? ReqVer { get; set; }

    public string? ReqfeSessionId { get; set; }

    public string? Reqchannel { get; set; }

    public string? ReqapiMode { get; set; }

    public string? ReqpartnerId { get; set; }

    public string? ReqcustomerId { get; set; }

    public int? Reqamount { get; set; }

    public string? ReqbankName { get; set; }

    public string? Reqifsc { get; set; }

    public string? ReqbeneAccNo { get; set; }

    public string? ReqbeneMobNo { get; set; }

    public string? ReqexternalRefNo { get; set; }

    public string? ReqSalt { get; set; }

    public string? Reqhash { get; set; }

    public string? Reqreference1 { get; set; }

    public string? Reqreference2 { get; set; }

    public string? Reqreference3 { get; set; }

    public string? Reqreference4 { get; set; }

    public string? Reqreference5 { get; set; }

    public string? ReqString { get; set; }

    public string? DepositorName { get; set; }

    public string? DepositorFname { get; set; }

    public string? DepositorLname { get; set; }

    public string? DepositorStateCode { get; set; }

    public string? DepositorPinCode { get; set; }

    public string? DepositorAddress { get; set; }

    public string? DepositorDob { get; set; }

    public string? DepositorMob { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public string? ResfeSessionId { get; set; }

    public string? ResCode { get; set; }

    public string? ReserrorCode { get; set; }

    public string? ResmessageText { get; set; }

    public string? ResresponseTimestamp { get; set; }

    public string? ResexternalRefNo { get; set; }

    public string? RestranId { get; set; }

    public string? Resrrn { get; set; }

    public int? ResAmount { get; set; }

    public string? ResCharges { get; set; }

    public string? ResbeneName { get; set; }

    public string? ResString { get; set; }

    public int? AisecttransactionId { get; set; }

    public DateTime? AisecttxnDate { get; set; }

    public string? ChargesInclusiveoGst18 { get; set; }

    public string? Gst18 { get; set; }

    public string? Apbshare { get; set; }

    public string? TotalCommissionInclusiveofGst { get; set; }

    public string? Gstdeduction18 { get; set; }

    public string? TotalAmountforSharing { get; set; }

    public string? Cspshare { get; set; }

    public string? Aisectshare { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }

    public string? RefundTxnId { get; set; }
}
