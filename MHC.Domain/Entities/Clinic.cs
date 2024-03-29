﻿using System;
using System.Collections.Generic;

namespace MHC.Domain.Entities;

public partial class Clinic
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public string? Status { get; set; }

    public double? Reviews { get; set; }

    public string? Link { get; set; }

    public Guid? IdImage { get; set; }

    public Guid? IdType { get; set; }

    public virtual Image? Image { get; set; }

    public virtual ClinicType? ClinicType { get; set; }
}
