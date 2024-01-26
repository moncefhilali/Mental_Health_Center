using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MHC.Domain.Entities;

public partial class ClinicType
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    [JsonIgnore]
    public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();
}
