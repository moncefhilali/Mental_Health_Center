using System;
using System.Collections.Generic;

namespace MHC.Domain.Entities;

public partial class Category
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    public virtual ICollection<Service> Services { get; set; } = new List<Service>();
}
