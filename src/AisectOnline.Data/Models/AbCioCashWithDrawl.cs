using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AbCioCashWithDrawl
{
    public int Wdid { get; set; }

    public int? ReqVer { get; set; }

    public string? ReqFeSessionId { get; set; }

    public string? ReqChannel { get; set; }

    public int? ReqPartnerId { get; set; }

    public string? ReqAgentId { get; set; }

    public int? ReqCustomerId { get; set; }

    public string? ReqApiMode { get; set; }

    public string? ReqBiometricData { get; set; }

    public string? ReqAadhaarTimestamp { get; set; }

    public string? ReqSkey { get; set; }

    public string? ReqHmac { get; set; }

    public string? ReqCertificateIdentifier { get; set; }

    public string? ReqUniqueDeviceCode { get; set; }

    public string? ReqRegisteredDeviceProviderCode { get; set; }

    public string? ReqRegisteredDeviceServiceId { get; set; }

    public string? ReqRegisteredDeviceServiceVersion { get; set; }

    public string? ReqRegisteredDeviceCode { get; set; }

    public string? ReqRegisteredDeviceModelId { get; set; }

    public string? ReqRegisteredDevicePublicKeyCertificate { get; set; }

    public string? ReqServiceCode { get; set; }

    public int? ReqAmount { get; set; }

    public string? ReqExternalRefNo { get; set; }

    public int? ReqHash { get; set; }

    public int? ReqKey1 { get; set; }

    public string? ReqKey2 { get; set; }

    public string? ReqString { get; set; }

    public string? ResFeSessionId { get; set; }

    public int? ResCode { get; set; }

    public string? ResErrorCode { get; set; }

    public string? ResMessageText { get; set; }

    public DateTime? ResResponseTimestamp { get; set; }

    public int? ResExternalRefNo { get; set; }

    public int? ResTranId { get; set; }

    public int? ResAmount { get; set; }

    public string? ResCharges { get; set; }

    public string? ResponseString { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }
}
