using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class OlympiadSchool
{
    public int Id { get; set; }

    public int? KioskId { get; set; }

    public int? CustomerId { get; set; }

    public int? ExamHall { get; set; }

    public int? RequiredFurniture { get; set; }

    public int? HighSpeedAndStableInternetConnection { get; set; }

    public int? SupervisorsAndStaff { get; set; }

    public int? ComputerLaptopFacility { get; set; }

    public int? ElectricityAndPowerBackupInverterGenerator { get; set; }

    public int? Cctvcameras { get; set; }

    public int? SeparateToiletsForBoyAndGirls { get; set; }

    public int? DrinkingWater { get; set; }

    public int? SecurityGuard { get; set; }

    public string? NameOfCoordinatorPrincipal { get; set; }

    public string? NameOfSchoolCollegeInstitute { get; set; }

    public string? AddressOfSchoolCollegeInstitute { get; set; }

    public string? ContactNumber { get; set; }

    public string? EmailId { get; set; }

    public string? City { get; set; }

    public int? State { get; set; }

    public int? District { get; set; }

    public string? PinCode { get; set; }

    public int? Class1 { get; set; }

    public int? Class2 { get; set; }

    public int? Class3 { get; set; }

    public int? Class4 { get; set; }

    public int? Class5 { get; set; }

    public int? Class6 { get; set; }

    public int? Class7 { get; set; }

    public int? Class8 { get; set; }

    public int? Class9 { get; set; }

    public int? Class10 { get; set; }

    public int? Class11 { get; set; }

    public int? Class12 { get; set; }

    public int? Graduate { get; set; }

    public int? PostGraduate { get; set; }

    public int? ExpectedNoStudents { get; set; }

    public int? IsAgree { get; set; }

    public DateTime? CreatedOn { get; set; }

    public string? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public string? UpdatedBy { get; set; }
}
