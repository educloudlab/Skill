using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class CarePaymentReqResp
{
    public int Id { get; set; }

    public string? ProposalNum { get; set; }

    public string? BusinessTypeCd { get; set; }

    public double? Premium { get; set; }

    public string? BaseAgentId { get; set; }

    public string? BaseProductId { get; set; }

    public string? SumInsured { get; set; }

    public string? Term { get; set; }

    public string? CoverType { get; set; }

    public string? Kioskcode { get; set; }

    public string? Vleid { get; set; }

    public string? OrderId { get; set; }

    public double? Amount { get; set; }

    public string? Client { get; set; }

    public string? Token { get; set; }

    public string? CustomerId { get; set; }

    public int? TransactionId { get; set; }

    public string? Message { get; set; }

    public string? Status { get; set; }

    public string? PolicyNum { get; set; }

    public string? PolicyMaturityDt { get; set; }

    public string? PolicyCommencementDt { get; set; }

    public string? PlanName { get; set; }

    public string? ProposalStatusCd { get; set; }

    public string? PaymentMode { get; set; }

    public string? ProposerEmailAddress { get; set; }

    public string? ProposerAddressLine1Lang1 { get; set; }

    public string? ProposerName { get; set; }

    public string? ProposerBirthDt { get; set; }

    public string? DepositDt { get; set; }

    public string? Jsonstring { get; set; }

    public decimal? AmountWithoutGst { get; set; }

    public decimal? AisectShare { get; set; }

    public decimal? BranchShare { get; set; }

    public decimal? TotalCommissionShare { get; set; }
}
