using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentLanguageKnown
{
    public int StudentLanguageId { get; set; }

    public int? StudentId { get; set; }

    public int? LanguageId { get; set; }

    public bool? IsRead { get; set; }

    public bool? IsSpeak { get; set; }

    public bool? IsWrite { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual MasterList? Language { get; set; }
}
