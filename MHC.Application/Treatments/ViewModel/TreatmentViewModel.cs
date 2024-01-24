using MHC.Application.Doctors.ViewModel;
using MHC.Application.Images.ViewModel;

namespace MHC.Application.Treatments.ViewModel
{
    public class TreatmentViewModel
    {
        public string? Topic { get; set; }

        public string? Body { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual DoctorViewModel? Doctor { get; set; }

        public virtual ImageViewModel? Image { get; set; }
    }
}
