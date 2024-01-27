using MHC.Application.Images.ViewModel;
using System.Collections.Generic;

namespace MHC.Application.Doctors.ViewModel
{
    public class DoctorIncludeViewModel
    {
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string? Specialty { get; set; }

        public virtual ImageViewModel? Image { get; set; }
    }
}
