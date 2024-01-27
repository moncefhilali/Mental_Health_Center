using MHC.Application.ClinicTypes.ViewModel;
using MHC.Application.Images.ViewModel;
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

        public virtual ImageViewModel? Image { get; set; }

        public virtual ClinicTypeViewModel? ClinicType { get; set; }
    }
}
