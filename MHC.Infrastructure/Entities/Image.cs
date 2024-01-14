using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHC.Infrastructure.Entities
{
    public partial class Image
    {
        public Image()
        {
            Clinic = new HashSet<Clinic>();
            Doctor = new HashSet<Doctor>();
            Service = new HashSet<Service>();
            Treatment = new HashSet<Treatment>();
        }

        public Guid Id { get; set; }
        public string Path { get; set; }

        public virtual ICollection<Clinic> Clinic { get; set; }
        public virtual ICollection<Doctor> Doctor { get; set; }
        public virtual ICollection<Service> Service { get; set; }
        public virtual ICollection<Treatment> Treatment { get; set; }
    }
}
