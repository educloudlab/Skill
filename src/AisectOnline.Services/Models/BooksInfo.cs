using System;
using System.Collections.Generic;

namespace AisectOnline.Services.Models;

public partial class BooksInfo
{
    public int BookId { get; set; }

    public int CourseId { get; set; }

    public string OrgBookName { get; set; } = null!;

    public string ReName { get; set; } = null!;
}
