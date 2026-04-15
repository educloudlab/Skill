using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MobikwikReqRes22092023
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public string? ReqType { get; set; }

    public string? ReqUid { get; set; }

    public string? ReqPwd { get; set; }

    public string? ReqCn { get; set; }

    public string? ReqOp { get; set; }

    public string? ReqCir { get; set; }

    public double? ReqAmt { get; set; }

    public double? AmtDeducted { get; set; }

    public double? AisectShare { get; set; }

    public double? BranchShare { get; set; }

    public string? ReqId { get; set; }

    public string? ReqPvalue { get; set; }

    public string? ReqAd1 { get; set; }

    public string? ReqAd2 { get; set; }

    public string? ResStatus { get; set; }

    public string? ResTxnId { get; set; }

    public string? RefundTxnId { get; set; }

    public double? ResBalance { get; set; }

    public double? ResDiscountPrice { get; set; }

    public string? Rescouponstatus { get; set; }

    public string? ResopRefNo { get; set; }

    public string? ResXml { get; set; }

    public double? PromoCodeDiscountAmount { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? ErrorMsg { get; set; }

    public int? CtznTxnId { get; set; }

    public string? RescustomerId { get; set; }

    public string? RescustomerName { get; set; }

    public string? ResdateOfPayment { get; set; }

    public string? ResorderId { get; set; }

    public string? ResbillMonth { get; set; }

    public string? ResRemarks { get; set; }

    public string? CitizenEnvironment { get; set; }

    public string? UniqueCode { get; set; }

    public double? MwalletBalance { get; set; }

    public double? TotalAmount { get; set; }

    public int? IsPartPayment { get; set; }
}
