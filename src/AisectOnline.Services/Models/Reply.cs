using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class Reply
{
    public int ReplyId { get; set; }

    public int? TopicId { get; set; }

    public string? Name { get; set; }

    public string? Emailid { get; set; }
}
