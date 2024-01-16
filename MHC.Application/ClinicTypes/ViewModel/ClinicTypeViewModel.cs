using MHC.Domain.Entities;

namespace MHC.Application.ClinicTypes.ViewModel
{
    public class ClinicTypeViewModel
    {
        public string? Name { get; set; }

        public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();
    }
}
