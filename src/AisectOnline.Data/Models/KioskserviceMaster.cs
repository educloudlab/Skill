using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class KioskserviceMaster
{
    public int KioskserviceId { get; set; }

    public string ServiceName { get; set; } = null!;

    public int? KiosktypeId { get; set; }

    public string? ServiceImage { get; set; }

    public string? ImagePath { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public bool? IsFinancialService { get; set; }

    public int? MenuId { get; set; }

    public string? DisplayName { get; set; }

    public int? ServiceType { get; set; }

    public virtual ICollection<InsurancePaymentMaster> InsurancePaymentMasters { get; set; } = new List<InsurancePaymentMaster>();

    public virtual KiosktypeMaster? Kiosktype { get; set; }

    public virtual ICollection<OnlineTransaction> OnlineTransactions { get; set; } = new List<OnlineTransaction>();

    public virtual ICollection<ServiceProviderMaster> ServiceProviderMasters { get; set; } = new List<ServiceProviderMaster>();
}
