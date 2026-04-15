using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class AjeeregPayment
{
    public int PayId { get; set; }

    public int? Studentid { get; set; }

    public string? Transactionids { get; set; }

    public string? Transactionidr { get; set; }

    public string? Aptransactionidr { get; set; }

    public string? Amountr { get; set; }

    public string? Transactionstatusr { get; set; }

    public string? Messager { get; set; }

    public string? ErrorR { get; set; }

    public string? SecureHashR { get; set; }

    public DateOnly? DateS { get; set; }

    public DateOnly? DateR { get; set; }
}
