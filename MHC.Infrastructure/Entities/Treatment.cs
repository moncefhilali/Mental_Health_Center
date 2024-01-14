using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHC.Infrastructure.Entities
{
    public partial class Treatment
    {
        public Guid Id { get; set; }
        public string Topic { get; set; }
        public string Body { get; set; }
        public DateTime? CreatedAt { get; set; }
        public Guid? IdImage { get; set; }
        public Guid? IdDoctor { get; set; }

        public virtual Doctor IdDoctorNavigation { get; set; }
        public virtual Image IdImageNavigation { get; set; }
    }
}
