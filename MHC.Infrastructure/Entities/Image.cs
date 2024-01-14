using System;
using System.Collections.Generic;

namespace MHC.Infrastructure.Entities;

public partial class Image
{
    public Guid Id { get; set; }

    public string? Path { get; set; }

    public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();

    public virtual ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
}
