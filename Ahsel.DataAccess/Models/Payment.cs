using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace Ahsel.DataAccess.Models;

public partial class Payment
{
    public int Id { get; set; }

    public int ClientRef { get; set; }

    public int Quantity { get; set; }

    public float Price { get; set; }

    public DateTime Date { get; set; }

    public string? Description { get; set; }

    public int ProjectRef { get; set; }
}
