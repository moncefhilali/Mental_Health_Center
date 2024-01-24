using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MHC.Domain.Entities;

public partial class Treatment
{
    public Guid Id { get; set; }

    public string? Topic { get; set; }

    public string? Body { get; set; }

    public DateTime? CreatedAt { get; set; }

    public Guid? IdImage { get; set; }

    public Guid? IdDoctor { get; set; }

    public virtual Doctor? Doctor { get; set; }

    public virtual Image? Image { get; set; }
}
