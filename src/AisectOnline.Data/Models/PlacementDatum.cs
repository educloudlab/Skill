using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class PlacementDatum
{
    public int PlacementId { get; set; }

    public int? StudentId { get; set; }

    public int? EmployerType { get; set; }

    public string? EmployerName { get; set; }

    public string? ContactDesignation { get; set; }

    public string? ContactNo { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public DateOnly? Doj { get; set; }

    public string? CtcbeforeTraining { get; set; }

    public string? CtcafterTraining { get; set; }

    public string? OfferLetterDoc { get; set; }

    public string? SalarySlipDoc { get; set; }

    public string? SalarySlipDoc2 { get; set; }

    public string? SalarySlipDoc3 { get; set; }

    public string? SelfEmployedDoc { get; set; }

    public int? Status { get; set; }

    public string? PlacementCode { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public int? VerifiedBy { get; set; }

    public DateTime? VerifiedOn { get; set; }

    public int? ApprovedBy { get; set; }

    public DateTime? ApprovedOn { get; set; }

    public int? BatchNo { get; set; }

    public string? EmployeeDesignation { get; set; }

    public int? TransactionId { get; set; }
}
