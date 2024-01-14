using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHC.Infrastructure.Entities
{
    public partial class Doctor
    {
        public Doctor()
        {
            Treatment = new HashSet<Treatment>();
        }

        public Guid Id { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Specialty { get; set; }
        public Guid? IdImage { get; set; }

        public virtual Image IdImageNavigation { get; set; }
        public virtual ICollection<Treatment> Treatment { get; set; }
    }
}
