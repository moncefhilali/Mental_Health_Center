using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace MHC.Infrastructure.Entities
{
    public partial class Service
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public double? Reviews { get; set; }
        public int? TotalEnrollment { get; set; }
        public DateTime? StartDate { get; set; }
        public Guid? IdCategory { get; set; }
        public Guid? IdImage { get; set; }

        public virtual Category IdCategoryNavigation { get; set; }
        public virtual Image IdImageNavigation { get; set; }
    }
}
