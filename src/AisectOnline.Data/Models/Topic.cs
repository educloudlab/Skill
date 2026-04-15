using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Topic
{
    public int TopicId { get; set; }

    public string? TopicDiscussion { get; set; }

    public string? EmailId { get; set; }

    public int? CourseId { get; set; }

    public bool? Reply { get; set; }

    public string? CourseName { get; set; }

    public DateTime? Dot { get; set; }
}
