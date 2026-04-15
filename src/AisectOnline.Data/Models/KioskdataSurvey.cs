using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskdataSurvey
{
    public int Kioskid { get; set; }

    public string? Kioskname { get; set; }

    public string? Kioskcode { get; set; }

    public int? CustomerId { get; set; }

    public int? KiosktypeId { get; set; }

    public string? Email { get; set; }

    public string? Website { get; set; }

    public string? PoliceRegNo { get; set; }

    public string? Tinno { get; set; }

    public string? Address { get; set; }

    public int? DistrictId { get; set; }

    public string? City { get; set; }

    public int? BlockId { get; set; }

    public int? VillageId { get; set; }

    public string? Panchayat { get; set; }

    public int? FieldId { get; set; }

    public int? CentreId { get; set; }

    public string? Zip { get; set; }

    public string? Mobile { get; set; }

    public string? Phone { get; set; }

    public string? FaxNo { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? ActiveFrom { get; set; }

    public DateTime? ExpireDate { get; set; }

    public string? Status { get; set; }

    public string? BranchManager { get; set; }

    public string? RequestNo { get; set; }

    public int? StateId { get; set; }

    public bool? IsStateDiscount { get; set; }

    public decimal? Kioskdiscount { get; set; }

    public bool? IsHokiosk { get; set; }

    public string? OmtId { get; set; }

    public long? VillageCensusCode { get; set; }

    public string? StoreCode { get; set; }

    public string? Mobile2 { get; set; }

    public bool? HasPanCardService { get; set; }

    public int? Sdaseats { get; set; }

    public string? NewKioskCode { get; set; }

    public string? OldKioskCode { get; set; }

    public string? Constituency { get; set; }

    public string? Latitude { get; set; }

    public string? Longitude { get; set; }
}
