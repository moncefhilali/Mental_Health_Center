using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MHC.Domain.Entities;

public partial class Image
{
    public Guid Id { get; set; }

    public string? Path { get; set; }

    [JsonIgnore]
    public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();

    [JsonIgnore]
    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    [JsonIgnore]
    public virtual ICollection<OurService> Services { get; set; } = new List<OurService>();

    [JsonIgnore]
    public virtual ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
}
