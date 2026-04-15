using System;
using System.Collections.Generic;

namespace AisectOnline.Data.Models;

public partial class ToDoList
{
    public int DoToListId { get; set; }

    public string? ToDoListName { get; set; }

    public string? Description { get; set; }
}
