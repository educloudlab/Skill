using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskAreaInSqfeetSurveySurvey
{
    public int Customerid { get; set; }

    public string? Reception { get; set; }

    public string? Office { get; set; }

    public string? Classroom1 { get; set; }

    public string? Classroom1Seating { get; set; }

    public string? Classroom2 { get; set; }

    public string? Classroom2Seating { get; set; }

    public string? Lab1 { get; set; }

    public string? Lab1Seating { get; set; }

    public string? Lab2 { get; set; }

    public string? Lab2Seating { get; set; }

    public string? Library { get; set; }

    public string? MaleToilet { get; set; }

    public string? FemaleToilet { get; set; }

    public string? Other { get; set; }

    public int? Status { get; set; }

    public string? UpdatedBy { get; set; }

    public DateTime? UpdatedDt { get; set; }

    public int? DisAirport { get; set; }

    public int? DisRailway { get; set; }

    public int? DisCityCenter { get; set; }

    public string? LibrarySeating { get; set; }

    public string? StaffRoom { get; set; }

    public string? StaffRoomSeating { get; set; }

    public string? CounsellingRoom { get; set; }

    public string? CounsellingRoomSeating { get; set; }

    public string? Cafeteria { get; set; }

    public string? CafeteriaSeating { get; set; }

    public string? Residential { get; set; }

    public string? ResidentialSeating { get; set; }

    public string? FirstAidKit { get; set; }

    public string? PhyDis { get; set; }

    public string? ParkingArea { get; set; }

    public string? FireSafety { get; set; }

    public int? TypeOfOwnership { get; set; }

    public string? PhasePower { get; set; }
}
