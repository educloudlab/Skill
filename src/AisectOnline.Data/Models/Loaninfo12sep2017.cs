using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Loaninfo12sep2017
{
    public int SrNo { get; set; }

    public string? LoanNo { get; set; }

    public DateTime? EmidueDate { get; set; }

    public string? Branch { get; set; }

    public string? CustomerName { get; set; }

    public string? PanaadharVoter { get; set; }

    public string? Mobile { get; set; }

    public string? AltMobile { get; set; }

    public string? Model { get; set; }

    public string? VehicleNo { get; set; }

    public DateTime? Dob { get; set; }

    public double? Advamount { get; set; }

    public double? Emi { get; set; }

    public double? Lppamount { get; set; }

    public double? ChequeBounceChanges { get; set; }

    public double? RepoCharge { get; set; }

    public int? Bucket { get; set; }

    public double? TotalAmount { get; set; }
}
