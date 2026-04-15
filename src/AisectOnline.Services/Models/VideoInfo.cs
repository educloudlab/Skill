using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class VideoInfo
{
    public int VideoId { get; set; }

    public int CourseId { get; set; }

    public string? VideoLink { get; set; }
}
