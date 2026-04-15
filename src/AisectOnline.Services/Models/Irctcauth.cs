using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Irctcauth
{
    public int AuthId { get; set; }

    public int? KdKioskId { get; set; }

    public int? IrkioskCodeAuth { get; set; }

    public int? Iraffiliated { get; set; }

    public int? Itrenewed { get; set; }

    public DateTime? IrrenewalExpiry { get; set; }

    public string? IrctcId { get; set; }

    public int? DeclarationYn { get; set; }

    public int? PaymentReceivedYn { get; set; }

    public string? KcDivisionResion { get; set; }

    public string? KcTehsil { get; set; }

    public int? KcBlock { get; set; }

    public string? KcLocality { get; set; }

    public int? KcPhoneNo { get; set; }

    public string? KcResidenceProof { get; set; }

    public string? KdDivisionRegion { get; set; }

    public string? KdTehsil { get; set; }

    public string? KdLocality { get; set; }

    public string? KdLandMark { get; set; }

    public string? KdShopAddressProof { get; set; }

    public string? KdNatureOfBussiness { get; set; }

    public int? KdExpectedNoOfTicketsBookedInAmonth { get; set; }

    public int? UpNoOfComputerOperator { get; set; }

    public string? UpConversantInTypingAndReading { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public string? UpConversantInOperating { get; set; }

    public int? UpPowerBackupYn { get; set; }
}
