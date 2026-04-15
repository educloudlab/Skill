using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class TelephoneOrderDetail
{
    public int Id { get; set; }

    public string? KioskCode { get; set; }

    public int Kioskid { get; set; }

    public string? OrderId { get; set; }

    public string OperatorCode { get; set; } = null!;

    public string? OperatorName { get; set; }

    public string ConsumerNo { get; set; } = null!;

    public decimal TxnAmount { get; set; }

    public string? BillDate { get; set; }

    public string? BillDueDate { get; set; }

    public string? BillNumber { get; set; }

    public string? MobileNo { get; set; }

    public string? EmailId { get; set; }

    public DateTime? EnterDate { get; set; }

    public string? SessionKey { get; set; }

    public int? VError { get; set; }

    public int? VResult { get; set; }

    public DateTime? VDate { get; set; }

    public string? VSignature { get; set; }

    public string? VOperatorTransactionId { get; set; }
}
