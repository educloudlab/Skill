using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class EWalletMaster
{
    public int EWalletId { get; set; }

    public bool? IsActive { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public virtual ICollection<EWalletTransaction> EWalletTransactions { get; set; } = new List<EWalletTransaction>();

    public virtual ICollection<StudentCourseFeeTransaction> StudentCourseFeeTransactions { get; set; } = new List<StudentCourseFeeTransaction>();
}
