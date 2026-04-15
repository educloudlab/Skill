using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class StudentQualification
{
    public int StudentQualificationId { get; set; }

    public int? QualificationId { get; set; }

    public int? BoardUniversityId { get; set; }

    public int? StreamId { get; set; }

    public int? YearOfPassing { get; set; }

    public int? DivisionId { get; set; }

    public int? StudentId { get; set; }

    public int? CourseTypeId { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public virtual MasterList? BoardUniversity { get; set; }

    public virtual MasterList? CourseType { get; set; }

    public virtual MasterList? Division { get; set; }

    public virtual QualificationMaster? Qualification { get; set; }

    public virtual StreamMaster? Stream { get; set; }
}
