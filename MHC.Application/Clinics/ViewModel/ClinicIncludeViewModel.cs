using MHC.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHC.Application.Clinics.ViewModel
{
    public class ClinicIncludeViewModel
    {
        public string? Name { get; set; }

        public string? Status { get; set; }

        public double? Reviews { get; set; }

        public string? Link { get; set; }

        public virtual Image? Image { get; set; }

        public virtual ClinicType? ClinicType { get; set; }
    }
}
