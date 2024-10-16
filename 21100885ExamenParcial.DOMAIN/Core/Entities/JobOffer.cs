using System;
using System.Collections.Generic;

namespace _21100885ExamenParcial.DOMAIN.Core.Entities;

public partial class JobOffer
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;

    public string Description { get; set; } = null!;

    public double? Salary { get; set; }

    public string? Location { get; set; }
}
