using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class Feedback
{
    public int FeedbackId { get; set; }

    public string EmailId { get; set; } = null!;

    public int Courseid { get; set; }

    public string Date { get; set; } = null!;

    public string FeedBackNote { get; set; } = null!;

    public bool Recommend { get; set; }

    public int Experience { get; set; }
}
