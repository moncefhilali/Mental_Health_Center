using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHC.Infrastructure.Entities
{
    public partial class Category
    {
        public Category()
        {
            Service = new HashSet<Service>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }

        public virtual ICollection<Service> Service { get; set; }
    }
}
