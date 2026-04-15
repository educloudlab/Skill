using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class TelephoneOperatorList
{
    public int Id { get; set; }

    public string? OperatorCode { get; set; }

    public string? OperatorName { get; set; }

    public string? OperatorType { get; set; }

    public int? MinimumAmount { get; set; }

    public int? MaximumAmount { get; set; }

    public bool? IsActive { get; set; }

    public string? IdentifierName { get; set; }

    public string? State { get; set; }
}
