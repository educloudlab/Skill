using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AbOnBoardingAdhaarKua
{
    public int AdhaarKuaid { get; set; }

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

    public string? RegisteredDeviceServiceId { get; set; }

    public string? ReqRegisteredDeviceServiceVersion { get; set; }

    public string? ReqregisteredDeviceCode { get; set; }

    public string? ReqRegisteredDeviceModelId { get; set; }

    public string? ReqRegisteredDevicePublicKeyCertificate { get; set; }

    public string? ReqServiceCode { get; set; }

    public string? ReqPan { get; set; }

    public string? ReqHash { get; set; }

    public string? ReqKey1 { get; set; }

    public string? ReqKey2 { get; set; }

    public string? ReqString { get; set; }

    public string? ResFeSessionId { get; set; }

    public int? ResCode { get; set; }

    public string? ResErrorcode { get; set; }

    public string? ResMessageText { get; set; }

    public DateTime? ResResponseTimestamp { get; set; }

    public string? ResCustName { get; set; }

    public DateTime? ResCustDob { get; set; }

    public string? ResCustGender { get; set; }

    public string? ResCustEmail { get; set; }

    public string? ResCustCareOf { get; set; }

    public string? ResCustHouse { get; set; }

    public string? ResCustStreet { get; set; }

    public string? ResCustLandMark { get; set; }

    public string? ResCustLocality { get; set; }

    public string? ResCustVtc { get; set; }

    public string? ResCustSubDistrict { get; set; }

    public string? ResCustDistrict { get; set; }

    public string? ResCustState { get; set; }

    public int? ResCustPinCode { get; set; }

    public string? ResCustPhoto { get; set; }

    public string? ResponseString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
