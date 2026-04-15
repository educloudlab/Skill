using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AbOnboardingAua
{
    public int AdhaarAuaid { get; set; }

    public int? ReqVer { get; set; }

    public string? ReqFeSessionId { get; set; }

    public string? ReqChannel { get; set; }

    public int? ReqPartnerId { get; set; }

    public string? ReqAgentId { get; set; }

    public string? ReqAdhaarId { get; set; }

    public string? ReqBiometricData { get; set; }

    public string? ReqAdhaarTimeStamp { get; set; }

    public string? ReqSkey { get; set; }

    public string? ReqHmac { get; set; }

    public string? ReqCertificateIdentifier { get; set; }

    public string? ReqUniqueDeviceCode { get; set; }

    public string? ReqRegisteredDeviceProviderCode { get; set; }

    public string? ReqregisteredDeviceServiceId { get; set; }

    public string? ReqRegisteredDeviceServiceVersion { get; set; }

    public string? ReqregisteredDeviceCode { get; set; }

    public string? ReqRegisteredDeviceModelId { get; set; }

    public string? ReqRegisteredDevicePublicKeyCertificate { get; set; }

    public string? ReqServiceCode { get; set; }

    public string? ReqEmailId { get; set; }

    public string? ReqOccupation { get; set; }

    public string? ReqAnnualIncome { get; set; }

    public int? ReqAgriculturalIncome { get; set; }

    public int? ReqNonAgriculturalIncome { get; set; }

    public string? ReqFatherName { get; set; }

    public string? ReqMotherName { get; set; }

    public string? ReqMaritalStatus { get; set; }

    public string? ReqNomineeFname { get; set; }

    public string? ReqNomineeMname { get; set; }

    public string? ReqNomineeLname { get; set; }

    public DateTime? ReqNomineeDob { get; set; }

    public string? ReqNomineeRelationship { get; set; }

    public string? ReqDbtConsent { get; set; }

    public string? ReqLocalAddress1 { get; set; }

    public string? ReqLocalAddress2 { get; set; }

    public string? ReqLocalAddress3 { get; set; }

    public string? ReqLocalAddress4 { get; set; }

    public string? ReqLocalCity { get; set; }

    public string? ReqLocalDistrict { get; set; }

    public string? ReqLocalState { get; set; }

    public string? ReqLocalPostalCode { get; set; }

    public int? ReqAmount { get; set; }

    public string? ReqHash { get; set; }

    public string? ReqKey1 { get; set; }

    public string? ReqKey2 { get; set; }

    public string? ReqString { get; set; }

    public string? ResFeSessionId { get; set; }

    public int? ResCode { get; set; }

    public string? ResErrorcode { get; set; }

    public string? ResMessageText { get; set; }

    public DateTime? ResResponseTimestamp { get; set; }

    public string? ResponseString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
