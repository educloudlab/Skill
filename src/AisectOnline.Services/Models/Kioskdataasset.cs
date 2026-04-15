using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Kioskdataasset
{
    public int KioskdataAssetsId { get; set; }

    public int? Kioskid { get; set; }

    public int? NoOfComputers { get; set; }

    public string? ComputerDescription { get; set; }

    public int? NoOfScanners { get; set; }

    public string? ScannerDescription { get; set; }

    public int? NoOfPrinters { get; set; }

    public string? PrinterDescription { get; set; }

    public int? NoOfCameras { get; set; }

    public string? CameraDescription { get; set; }

    public int? AvgStudentPerDay { get; set; }

    public int? AvgGeneralUsersPerDay { get; set; }

    public string? NearByColleges { get; set; }

    public string? NearByHostels { get; set; }

    public string? NearBySchools { get; set; }

    public string? NearByPrivateOffices { get; set; }

    public string? NearByGovtOffices { get; set; }

    public string? NearByOtherInstitutions { get; set; }

    public int? InternetConnectionType { get; set; }

    public decimal? PowerCutTimeInYourAreaHrs { get; set; }

    public decimal? BackupPowerTimeHrs { get; set; }

    public int? ComfortLevelWithApplicationScale10 { get; set; }

    public string? AnyOtherBusiness { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public bool? IsActive { get; set; }

    public string? Status { get; set; }
}
