using System;
using System.Collections.Generic;

namespace MHC.Domain.Entities;

public partial class Image
{
    public Guid Id { get; set; }

    public string? Path { get; set; }

    public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();

    public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

    public virtual ICollection<OurService> Services { get; set; } = new List<OurService>();

    public virtual ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
}
