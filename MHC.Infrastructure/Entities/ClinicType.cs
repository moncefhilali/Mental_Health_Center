using System;
using System.Collections.Generic;

namespace MHC.Infrastructure.Entities;

public partial class ClinicType
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();
}
