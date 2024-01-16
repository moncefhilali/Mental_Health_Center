using MHC.Domain.Entities;

namespace MHC.Application.Images.ViewModel
{
    public class ImageViewModel
    {
        public string? Path { get; set; }

        public virtual ICollection<Clinic> Clinics { get; set; } = new List<Clinic>();

        public virtual ICollection<Doctor> Doctors { get; set; } = new List<Doctor>();

        public virtual ICollection<OurService> Services { get; set; } = new List<OurService>();

        public virtual ICollection<Treatment> Treatments { get; set; } = new List<Treatment>();
    }
}
