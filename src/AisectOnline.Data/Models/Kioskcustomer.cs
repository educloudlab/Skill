using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Kioskcustomer
{
    public int CustomerId { get; set; }

    public string? FirstName { get; set; }

    public string? MiddleName { get; set; }

    public string? LastName { get; set; }

    public int? Gender { get; set; }

    public DateTime? DateofBirth { get; set; }

    public string? FatherHusbandName { get; set; }

    public string? Address { get; set; }

    public int? DistrictId { get; set; }

    public string? City { get; set; }

    public string? Zip { get; set; }

    public string? Mobile { get; set; }

    public string? Email { get; set; }

    public string? Phone { get; set; }

    public DateTime? DateofAnniv { get; set; }

    public string? Panno { get; set; }

    public int? LegalDocumentId { get; set; }

    public string? LegalDocumentNo { get; set; }

    public bool? IsActive { get; set; }

    public string? Status { get; set; }

    public int? EWalletId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? StateId { get; set; }

    public string? LoginId { get; set; }

    public string? Password { get; set; }

    public string? AccountNo { get; set; }

    public string? Ifsccode { get; set; }

    public string? AccountHolderName { get; set; }

    public string? BankName { get; set; }

    public string? BranchAddress { get; set; }

    public int? NetBanking { get; set; }

    public string? Aadhar { get; set; }

    public string? Email2 { get; set; }

    public string? Email3 { get; set; }

    public string? OfflineData { get; set; }

    public string? Qualification { get; set; }

    public virtual ICollection<Kioskdatum> Kioskdata { get; set; } = new List<Kioskdatum>();

    public virtual ICollection<OnlineTransaction> OnlineTransactions { get; set; } = new List<OnlineTransaction>();
}
