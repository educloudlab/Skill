using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class MasterListType
{
    public int MasterListTypeId { get; set; }

    public string? TypeName { get; set; }

    public string? TableName { get; set; }

    public bool? Editable { get; set; }
}
