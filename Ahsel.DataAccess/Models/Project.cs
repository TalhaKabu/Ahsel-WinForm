using System;
using System.Collections.Generic;

namespace Ahsel.DataAccess.Models;

public partial class Project
{
    public int Id { get; set; }

    public string Name { get; set; } = null!;

    public string? Description { get; set; }
}
