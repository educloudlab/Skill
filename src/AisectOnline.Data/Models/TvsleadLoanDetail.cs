using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class TvsleadLoanDetail
{
    public int Id { get; set; }

    public string? Name { get; set; }

    public int? KioskId { get; set; }

    public string? PhoneNumber { get; set; }

    public string? MobileNo { get; set; }

    public string? PersonalEmail { get; set; }

    public string? Address { get; set; }

    public string? PermanentAddress { get; set; }

    public string? StateCode { get; set; }

    public string? DistrictCode { get; set; }

    public string? TalukaCode { get; set; }

    public string? CityCode { get; set; }

    public string? PinCode { get; set; }

    public string? LeadCreatedBy { get; set; }

    public string? Product { get; set; }

    public DateTime? AppointmentDate { get; set; }

    public string? BulkPartnerAgentId { get; set; }

    public string? BulkPartnerCode { get; set; }

    public string? BulkPartnerName { get; set; }

    public DateTime? DateAndTimeOfMeeting { get; set; }

    public string? AvailableTrack { get; set; }

    public string? ProductCode { get; set; }

    public string? TypeOfImplement { get; set; }

    public string? ImplementBrands { get; set; }

    public decimal? TrxnCommission { get; set; }

    public string? Remark { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedDate { get; set; }

    public DateTime? UpdateDate { get; set; }

    public string? ResId { get; set; }

    public string? ResRelatedId { get; set; }

    public string? ResIsCreated { get; set; }

    public string? Resxml { get; set; }
}
