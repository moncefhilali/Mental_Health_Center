using System;
using System.Collections.Generic;

namespace MHC.Infrastructure.Entities;

public partial class Doctor
{
    public Guid Id { get; set; }

    public string? Firstname { get; set; }

    public string? Lastname { get; set; }

    public string? Specialty { get; set; }

    public Guid? IdImage { get; set; }

    public virtual Image? IdImageNavigation { get; set; }

    public virtual ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
}
