using MHC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHC.Application.Doctors.ViewModel
{
    public class DoctorViewModel
    {
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string? Specialty { get; set; }

        public Guid? IdImage { get; set; }

        public virtual Image? IdImageNavigation { get; set; }

        public virtual ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
    }
}
