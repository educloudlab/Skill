using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MasterList
{
    public int MasterListId { get; set; }

    public string? MasterValue { get; set; }

    public string? MasterValue1 { get; set; }

    public int? MasterListTypeId { get; set; }

    public virtual ICollection<BookMaster> BookMasterAuthors { get; set; } = new List<BookMaster>();

    public virtual ICollection<BookMaster> BookMasterMedia { get; set; } = new List<BookMaster>();

    public virtual ICollection<BookMaster> BookMasterPublications { get; set; } = new List<BookMaster>();

    public virtual ICollection<BookMaster> BookMasterSuppliers { get; set; } = new List<BookMaster>();

    public virtual ICollection<CyberPlateRechargeUrldetail> CyberPlateRechargeUrldetailCyberPlatConnectionTypes { get; set; } = new List<CyberPlateRechargeUrldetail>();

    public virtual ICollection<CyberPlateRechargeUrldetail> CyberPlateRechargeUrldetailRechargeTypes { get; set; } = new List<CyberPlateRechargeUrldetail>();

    public virtual ICollection<EWalletTransaction> EWalletTransactions { get; set; } = new List<EWalletTransaction>();

    public virtual ICollection<ItemMaster> ItemMasters { get; set; } = new List<ItemMaster>();

    public virtual ICollection<OnlineTransaction> OnlineTransactions { get; set; } = new List<OnlineTransaction>();

    public virtual ICollection<ServiceFeeType> ServiceFeeTypes { get; set; } = new List<ServiceFeeType>();

    public virtual ICollection<ServiceProviderMaster> ServiceProviderMasters { get; set; } = new List<ServiceProviderMaster>();

    public virtual ICollection<SessionCourseFee> SessionCourseFees { get; set; } = new List<SessionCourseFee>();

    public virtual ICollection<StudentDispatchItem> StudentDispatchItems { get; set; } = new List<StudentDispatchItem>();

    public virtual ICollection<StudentDispatch> StudentDispatches { get; set; } = new List<StudentDispatch>();

    public virtual ICollection<StudentDocumentsDetail> StudentDocumentsDetails { get; set; } = new List<StudentDocumentsDetail>();

    public virtual ICollection<StudentEmploymentDetail> StudentEmploymentDetails { get; set; } = new List<StudentEmploymentDetail>();

    public virtual ICollection<StudentExamDocumentsDetail> StudentExamDocumentsDetails { get; set; } = new List<StudentExamDocumentsDetail>();

    public virtual ICollection<StudentLanguageKnown> StudentLanguageKnowns { get; set; } = new List<StudentLanguageKnown>();

    public virtual ICollection<StudentQualification> StudentQualificationBoardUniversities { get; set; } = new List<StudentQualification>();

    public virtual ICollection<StudentQualification> StudentQualificationCourseTypes { get; set; } = new List<StudentQualification>();

    public virtual ICollection<StudentQualification> StudentQualificationDivisions { get; set; } = new List<StudentQualification>();
}
