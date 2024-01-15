using MHC.Domain.Entities;

namespace MHC.Application.Clinics.ViewModel
{
    public class ClinicViewModel
    {
        public string? Name { get; set; }

        public string? Status { get; set; }

        public double? Reviews { get; set; }

        public string? Link { get; set; }

        public Guid? IdImage { get; set; }

        public Guid? IdType { get; set; }

        public virtual Image? IdImageNavigation { get; set; }

        public virtual ClinicType? IdTypeNavigation { get; set; }
    }
}
