using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentLoginRegistration
{
    public int Id { get; set; }

    public string? FullName { get; set; }

    public string? Mobile { get; set; }

    public string? EMail { get; set; }

    public int? StateId { get; set; }

    public int? DistrictId { get; set; }

    public string? TrackingNumber { get; set; }

    public string? Login { get; set; }

    public string? Password { get; set; }

    public DateOnly? CreatedOn { get; set; }

    public string? StudentType { get; set; }

    public int? StudentId { get; set; }

    public string? LeadRespStatus { get; set; }

    public string? LeadRespMessage { get; set; }

    public string? LeadRespId { get; set; }

    public string? LeadRespRelatedId { get; set; }

    public string? LeadRespEntryDate { get; set; }

    public string? UtmSource { get; set; }

    public string? UtmMedium { get; set; }

    public string? UtmCampaign { get; set; }

    public string? UtmTerm { get; set; }

    public string? UtmContent { get; set; }

    public string? LeadSource { get; set; }

    public string? ProspectId { get; set; }

    public string? MxCampus { get; set; }

    public string? PasswordChanged { get; set; }

    public DateTime? PasswordChangedOn { get; set; }

    public string? MastercomputechReqApi { get; set; }

    public string? MastercomputechResApi { get; set; }

    public string? MastercomputechReqApi2 { get; set; }

    public string? MastercomputechResApi2 { get; set; }
}
