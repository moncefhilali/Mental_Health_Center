using MHC.Domain.Entities;

namespace MHC.Application.Doctors.ViewModel
{
    public class DoctorViewModel
    {
        public string? Firstname { get; set; }

        public string? Lastname { get; set; }

        public string? Specialty { get; set; }

        public virtual Image? Image { get; set; }
    }
}
