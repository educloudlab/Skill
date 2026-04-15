using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class MstFranchiseeDtl
{
    public int Id { get; set; }

    public string? Surveyer1Code { get; set; }

    public string? Surveyer1Name { get; set; }

    public string? Surveyer2Code { get; set; }

    public string? Surveyer2Name { get; set; }

    public DateTime? InspectionDate { get; set; }

    public string? KioskCode { get; set; }

    public DateTime? CreateOn { get; set; }

    public string? IsOtherFranchiseeUse { get; set; }

    public string? OthrNetworkName { get; set; }

    public string? OthrNetworkCourseName { get; set; }

    public string? OthrUniversityName { get; set; }

    public string? OthrUnivCourseName { get; set; }

    public string? OthrNgoName { get; set; }

    public string? OtherNgoCourseName { get; set; }

    public string? BoardName { get; set; }

    public string? BoardCompetitors { get; set; }

    public string? DoYouRunSchool { get; set; }

    public string? SchoolName { get; set; }

    public string? SchoolLevel { get; set; }

    public string? DoYouRunCotching { get; set; }

    public string? CotchingName { get; set; }

    public string? CotchingRunFor { get; set; }

    public string? CompietitorOfAisect { get; set; }

    public string? IsStudPlacementSupport { get; set; }

    public string? AvgSalaryPaidPerMonth { get; set; }

    public string? DoYouRunVocationalCenter { get; set; }

    public string? DoYouHaveLab { get; set; }

    public string? LabDtls { get; set; }

    public string? UnresolvedIssue { get; set; }

    public string? ErmDoneInGrs { get; set; }

    public string? FeedbackFrmBranchManger { get; set; }

    public string? RemarksFrmSurveyor { get; set; }

    public string? NsdcglowSign { get; set; }

    public string? NsdcnormalSign { get; set; }

    public string? NotPresent { get; set; }
}
