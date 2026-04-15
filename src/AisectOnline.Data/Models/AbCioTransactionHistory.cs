using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AbCioTransactionHistory
{
    public int HistoryId { get; set; }

    public int? ReqVer { get; set; }

    public string? ReqFeSessionId { get; set; }

    public string? ReqChannel { get; set; }

    public int? ReqPartnerId { get; set; }

    public string? ReqAgentId { get; set; }

    public DateTime? ReqFromDate { get; set; }

    public DateTime? ReqToDate { get; set; }

    public string? ReqHash { get; set; }

    public string? ReqString { get; set; }

    public string? ResFeSessionId { get; set; }

    public int? ResCode { get; set; }

    public string? ResErrorcode { get; set; }

    public string? ResMessageText { get; set; }

    public string? ResResponseTimestamp { get; set; }

    public string? ResAgentId { get; set; }

    public DateTime? ResTranDateTime { get; set; }

    public string? ResTranId { get; set; }

    public int? ResCustomerId { get; set; }

    public string? ResTxnType { get; set; }

    public string? ResTxnStatus { get; set; }

    public int? ResAmount { get; set; }

    public string? ResCharges { get; set; }

    public string? ResponseString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
