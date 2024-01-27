using MHC.Application.Doctors.ViewModel;
using MHC.Application.Images.ViewModel;

namespace MHC.Application.Treatments.ViewModel
{
    public class TreatmentIncludeViewModel
    {
        public string? Topic { get; set; }

        public string? Body { get; set; }

        public DateTime? CreatedAt { get; set; }

        public virtual DoctorIncludeViewModel? Doctor { get; set; }

        public virtual ImageViewModel? Image { get; set; }
    }
}
