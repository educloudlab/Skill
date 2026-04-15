using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class TblBajajVehicle
{
    public int Id { get; set; }

    public string? Source { get; set; }

    public string? SubChannelCode { get; set; }

    public string? Title { get; set; }

    public string? FirstName { get; set; }

    public string? Lastname { get; set; }

    public string? MobileNumber { get; set; }

    public string? LeadType { get; set; }

    public string? Lannumber { get; set; }

    public double? PreApprovedAmount { get; set; }

    public DateTime? DateofBirth { get; set; }

    public string? EmailId { get; set; }

    public string? Language { get; set; }

    public int? StateId { get; set; }

    public string? City { get; set; }

    public int? Pincode { get; set; }

    public string? ProductType { get; set; }

    public string? ProductMake { get; set; }

    public string? Model { get; set; }

    public DateTime? PurchaseDate { get; set; }

    public string? Address1 { get; set; }

    public string? Address2 { get; set; }

    public string? AgentComment { get; set; }

    public string? Dma { get; set; }

    public string? Response { get; set; }

    public int? Kioskid { get; set; }

    public DateTime? CreateDate { get; set; }
}
