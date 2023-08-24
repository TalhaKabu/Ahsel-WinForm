using System;
using System.ComponentModel.DataAnnotations;

namespace Ahsel.DataAccess.Models;

public partial class Client
{
    public int Id { get; set; }

    public string Name { get; set; }

    public int ProjectRef { get; set; }
}
