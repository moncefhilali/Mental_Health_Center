using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHC.Infrastructure.Entities
{
    public partial class Clinic
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Status { get; set; }
        public double? Reviews { get; set; }
        public string Link { get; set; }
        public Guid? IdImage { get; set; }
        public Guid? IdType { get; set; }

        public virtual Image IdImageNavigation { get; set; }
        public virtual Type IdTypeNavigation { get; set; }
    }
}
