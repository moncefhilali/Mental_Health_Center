using System;
using System.Collections.Generic;
using System.Text.Json.Serialization;

namespace MHC.Domain.Entities;

public partial class Category
{
    public Guid Id { get; set; }

    public string? Name { get; set; }

    [JsonIgnore]
    public virtual ICollection<OurService> Services { get; set; } = new List<OurService>();
}
