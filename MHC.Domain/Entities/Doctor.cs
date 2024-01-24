using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MHC.Domain.Entities;

public partial class Doctor
{
    public Guid Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Specialty { get; set; }

    public Guid? IdImage { get; set; }

    public virtual Image? Image { get; set; }

    [JsonIgnore]
    public virtual ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
}
