using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class AisectBranchMaster2
{
    public int Id { get; set; }

    public string? State { get; set; }

    public string? District { get; set; }

    public string? Zone { get; set; }

    public string? Zonalhead { get; set; }

    public string? Zonalcoordinator { get; set; }

    public string? Statecoordinator { get; set; }

    public string? Regionalmanager { get; set; }

    public string? Bdename { get; set; }

    public string? Regionaloffice { get; set; }

    public string? Dmname { get; set; }

    public string? Admname { get; set; }

    public string? Bmname { get; set; }

    public double? ZhCode { get; set; }

    public double? ShCode { get; set; }

    public double? RmCode { get; set; }
}
