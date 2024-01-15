using MHC.Domain.Entities;

namespace MHC.Application.Treatments.ViewModel
{
    public class TreatmentViewModel
    {
        public string? Topic { get; set; }

        public string? Body { get; set; }

        public DateTime? CreatedAt { get; set; }

        public Guid? IdImage { get; set; }

        public Guid? IdDoctor { get; set; }

        public virtual Doctor? IdDoctorNavigation { get; set; }

        public virtual Image? IdImageNavigation { get; set; }
    }
}
