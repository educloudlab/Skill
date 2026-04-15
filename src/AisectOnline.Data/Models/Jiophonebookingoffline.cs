using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Jiophonebookingoffline
{
    public int Id { get; set; }

    public string? OrderId { get; set; }

    public int? KioskId { get; set; }

    public string? KioskCode { get; set; }

    public string? KioskName { get; set; }

    public string? Mobile { get; set; }

    public string? Address { get; set; }

    public string? CustomerName { get; set; }

    public string? CustomerMob { get; set; }

    public int? CustomerPin { get; set; }

    public int? NoOfDevice { get; set; }

    public int? Amount { get; set; }

    public DateTime? TxnDate { get; set; }

    public int? TransactionId { get; set; }

    public string? TxnMessage { get; set; }

    public string? TxnStatus { get; set; }

    public string? Aisectshare { get; set; }

    public string? BranchShare { get; set; }

    public string? ThirdPartShare { get; set; }
}
