using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class StudentBookBulkDispatch
{
    public int StudentBookBulkDispatchId { get; set; }

    public int? StudentBookDispatchMasterId { get; set; }

    public string? StudentName { get; set; }

    public string? RegistrationNo { get; set; }

    public string? NewRegistrationNo { get; set; }

    public string? StudentMobileNo { get; set; }

    public string? CourseName { get; set; }

    public string? CourseMedium { get; set; }

    public string? BooksName { get; set; }

    public int? ModuleCount { get; set; }

    public string? DispatchAt { get; set; }

    public string? DispatchAddress { get; set; }

    public string? DispatchOrderNo { get; set; }

    public string? CourierName { get; set; }

    public string? BranchManager { get; set; }

    public string? KioskCode { get; set; }

    public string? University { get; set; }

    public int? DispatchQuantity { get; set; }

    public int? CreatedBy { get; set; }

    public DateTime? CreatedOn { get; set; }

    public int? UpdatedBy { get; set; }

    public DateTime? UpdatedOn { get; set; }

    public int? DispatchStatus { get; set; }

    public string? RefDispatchNo { get; set; }
}
