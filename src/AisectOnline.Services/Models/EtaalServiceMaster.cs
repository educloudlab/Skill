using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class EtaalServiceMaster
{
    public int EtaalServiceId { get; set; }

    public string? Project { get; set; }

    public string? ServiceCode { get; set; }

    public string? ServiceName { get; set; }

    public string? DescriptionOfSevice { get; set; }

    public string? StandardServiceName { get; set; }

    public string? MinorStandardService { get; set; }

    public string? Cate { get; set; }

    public string? Mission { get; set; }

    public string? IsAcross { get; set; }

    public string? Service { get; set; }

    public string? Workflow { get; set; }

    public string? Database { get; set; }
}
